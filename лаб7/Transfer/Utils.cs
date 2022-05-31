namespace Transfer
{
    using System;

    class Utils
    {

        //As before
        // Reverse a string

        public static void Reverse(ref string s)
        {
            string sRev = "";

            for (int k = s.Length-1; k >= 0 ; k--)
              {
                sRev = sRev + s[k];
            }
            // Return result to caller
            s = sRev;
            
        }
    }


}

