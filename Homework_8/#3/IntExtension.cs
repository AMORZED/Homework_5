namespace _IntExtension
{
    public static class IntExtension
    {
        public static int BiggestValue(this int[] array)  // Находит и возвращает наибольшее целочисленное значение в массиве
        {
            int BiggestValue = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                if (BiggestValue < array[i])
                {
                    BiggestValue = array[i];
                }
            }
            return BiggestValue;
        }
    }
}
