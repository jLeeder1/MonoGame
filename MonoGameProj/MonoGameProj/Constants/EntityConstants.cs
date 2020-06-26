namespace MonoGameProj.Constants
{
    public static class EntityConstants
    {
        public static class SmallHandgunConstants
        {
            public static int Small_Handgun_Bullet_Weight = 5;
            public static int Small_Handgun_Base_Speed = 12;
            public static string Small_Handgun_Texture_Name = "bullet";
            public static float Small_Handgun_Rate_Of_Fire = 0.35f; // Values closer to 0 mean greater rate of fire
        }

        public static class DimensionConstants
        {
            public static float Base_Width_Value = 5.0F;
            public static float Base_Height_Value = 5.0F;
        }

        public static class BulletDimensionConstants
        {
            public static float Handgun_Width_Value = 5.0F;
            public static float Handgun_Height_Value = 2.0F;
        }
    }
}
