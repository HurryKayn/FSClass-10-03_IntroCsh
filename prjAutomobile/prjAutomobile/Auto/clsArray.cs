namespace ClsArray
{
    internal class clsArray
    {
       private string[] passeggeri = new string[5];
        private string[] automobili;

        public string[] ElencoAutomobili(int numauto)
        {
            automobili=new string[numauto];
            automobili[0] = "DW987yt";
            automobili[1] = null;
            automobili[2] = "AB988yt";

            for (int i=0;i<automobili.Length;i++)
            {

            }
            return automobili;
        }
    }
}