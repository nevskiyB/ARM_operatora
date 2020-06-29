using System;

namespace ARM
{
    public class Polynomial
    {
        public double[][] PolyT;//Массив температруных полиномов
        public double[] PolyV;//Полином скорости конвейера

        public Polynomial(Bake.Zone zone)
        {
            switch (zone)
            {
                case Bake.Zone.zon5:
                    PolyV = new double[3] { 0.000007666666667, -0.000783095238095, 0.025078571428571 };
                    PolyT = new double[5][];
                    PolyT[0] = new double[2] { -0.0934, 207.1963 };
                    PolyT[1] = new double[2] { 0.0340, 156.7454 };
                    PolyT[2] = new double[2] { -0.0031, 158.5998 };
                    PolyT[3] = new double[4] { 0.0001332888889, -0.0197895714286, 0.8110270634919, 258.1304690476204 };
                    PolyT[4] = new double[4] { -0.0021967333333, 0.2343136666667, -7.9037704761904, 128.0346857142843 };
                    break;
                case Bake.Zone.zon6:
                    PolyV = new double[3] { 0.000002285714286, -0.000352857142857, 0.017107142857143 };
                    PolyT = new double[6][];
                    PolyT[0] = new double[4] { 0.0036, -0.4184, 16.2757, 1.9320 };
                    PolyT[1] = new double[2] { -0.3467, 173.8453 };
                    PolyT[2] = new double[2] { -0.0769, 154.6770 };
                    //PolyT[3] = new double[2] { 0.4579, 181.7857 };
                    PolyT[3] = new double[3] { -0.0163047238095, 1.6564632380952, 160.2947942857144 };
                    PolyT[4] = new double[4] { 0.0053, -0.6084, 22.4065, 11.3981 };
                    PolyT[5] = new double[4] { -0.0022, 0.2414, -9.1154, 156.2759 };
                    break;
                case Bake.Zone.zon12:
                    PolyV = new double[2] { 0, 0.0125 };
                    PolyT = new double[12][];
                    PolyT[0] = new double[4] { -0.0094, 1.1926, -41.4271, 580.9477 };
                    PolyT[1] = new double[4] { -0.0046, 0.5340, -16.9301, 309.0647 };
                    PolyT[2] = new double[4] { -0.0027, 0.3636, -13.4332, 319.9927 };
                    PolyT[3] = new double[3] { -0.0153, 1.7309, 135.4131 };
                    PolyT[4] = new double[3] { 0.0137, -0.8599, 177.8103 };
                    PolyT[5] = new double[3] { -0.0034, 0.1127, 159.1453 };
                    PolyT[6] = new double[4] { 0.0006, -0.0828, 3.5208, 121.6415 };
                    PolyT[7] = new double[4] { 0.0003, -0.0393, 1.6026, 142.3403 };
                    PolyT[8] = new double[3] { -0.0080, 0.1451, 159.3355 };
                    PolyT[9] = new double[4] { -0.0013, 0.1635, -5.4302, 232.8784 };
                    PolyT[10] = new double[4] { -0.0062, 0.7478, -23.9953, 509.0018 };
                    PolyT[11] = new double[4] { 0.0021, -0.2789, 9.4296, 120.1809 };
                    break;
                default:
                    break;
            }
        }

        public double GetFromPoly(double[] Poly, double timeConst)
        {
            double ans = 0;

            for (int i = 0; i < Poly.Length; i++)
            {
                ans = ans + Poly[i] * Math.Pow(timeConst, Poly.Length - (i + 1));
            }

            return ans;
        }//Возвращает значение полинома polynomial от аргумента timeConst

        public double[] GetZoneTemperature(double timeConst)
        {
            double[] Temperatures = new double[PolyT.GetLength(0)];

            for (int i = 0; i < PolyT.GetLength(0); i++)
            {
                Temperatures[i] = GetFromPoly(PolyT[i], timeConst);
            }

            return Temperatures;
        }//Возвращает температуры зон
    }//Класс содержащий полиномы T(Tconst) и V(Tconst)
}
