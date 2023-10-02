using Lang;

Constants Constants = new();

Console.Write(Constants.InputMessage);

switch (int.Parse(Console.ReadLine()))
{
    case 1:
        Messages(Constants.Month.January, Constants.Day.c);
        break;
    case 2:
        Messages(Constants.Month.February, Constants.Day.a);
        break;
    case 3:
        Messages(Constants.Month.March, Constants.Day.c);
        break;
    case 4:
        Messages(Constants.Month.April, Constants.Day.b);
        break;
    case 5:
        Messages(Constants.Month.May, Constants.Day.c);
        break;
    case 6:
        Messages(Constants.Month.June, Constants.Day.b);
        break;
    case 7:
        Messages(Constants.Month.July, Constants.Day.c);
        break;
    case 8:
        Messages(Constants.Month.August, Constants.Day.c);
        break;
    case 9:
        Messages(Constants.Month.September, Constants.Day.b);
        break;
    case 10:
        Messages(Constants.Month.October, Constants.Day.c);
        break;
    case 11:
        Messages(Constants.Month.November, Constants.Day.b);
        break;
    case 12:
        Messages(Constants.Month.December, Constants.Day.c);
        break;
    default:
        Console.WriteLine(Constants.WrongMessage);
        break;
}

static void Messages(Constants.Month nameMonth, Constants.Day amountDays)
{
    Console.WriteLine(Constants.OutputMessage, (int)nameMonth, nameMonth, (int)amountDays, Season((int)nameMonth));
}

static string Season(int numberMonth)
{
    if (numberMonth == 12 || numberMonth == 1 || numberMonth == 2)
    {
        return Constants.Season.Winter.ToString();
    }
    else if (numberMonth == 3 || numberMonth == 4 || numberMonth == 5)
    {
        return Constants.Season.Spring.ToString();
    }
    else if (numberMonth == 6 || numberMonth == 7 || numberMonth == 8)
    {
        return Constants.Season.Summer.ToString();
    }
    else if (numberMonth == 9 || numberMonth == 10 || numberMonth == 11)
    {
        return Constants.Season.Autumn.ToString();
    }

    return Constants.Season.Undefined.ToString();
}