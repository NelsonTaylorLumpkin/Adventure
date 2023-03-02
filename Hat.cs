using System;
namespace Quest
{
    public class Hat
    {
        public int Shininess { get; set; }

        public string ShininessDescription
        {
            get
            {
                if (Shininess < 2)
                {
                    return "dull";
                }

                if (Shininess >= 2 && Shininess <= 5)
                {
                    return "noticeable";
                }
                if (Shininess >= 6 && Shininess <= 9)
                {
                    return "bright";
                }
                else
                {
                    return "blinding";
                }
            }


        }
        
    }
}