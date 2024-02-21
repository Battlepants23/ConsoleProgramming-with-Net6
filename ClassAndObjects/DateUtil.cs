
    internal static class DateUtil
    {

    public static int YearofBirth(int age)
    {
        return DateTime.Now.Year - age ;
    }


    public static int YearofBirth(DateTime DateofBirth)
    {
        if (DateofBirth == null)
        {

            return 0;

        }
        else
        {

            return DateofBirth.Year;

        }


    }

    public static int Age(DateTime DateofBirth)
    {
        if (DateofBirth == null)
        {

            return 0;

        }
        else
        {

            return DateTime.Now.Year - DateofBirth.Year;

        }



    }

}
