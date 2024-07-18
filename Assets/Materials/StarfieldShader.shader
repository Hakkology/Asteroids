Shader "Unlit/StarfieldShader"
{
    Properties
    {
        _StarDensity ("Star Density", Float) = 0.3
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            float _StarDensity;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // Yıldızların rastgele konumlarını ve parlamalarını hesaplama
                float x = frac(sin(dot(i.uv, float2(12.9898, 78.233))) * 43758.5453);
                float y = frac(sin(dot(i.uv, float2(96.233, 54.879))) * 43758.5453);
                float star = step(0.98, x) * step(0.98, y);
                star *= _StarDensity; // Yıldız yoğunluğunu ayarlama

                return fixed4(star, star, star, 1.0);
            }
            ENDCG
        }
    }
}
