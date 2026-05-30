/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 мая 2026 15:42:03
 * Version: 1.0.286
 */

using System;

public class MyParser
{
    public int TryCathParse(string str)
    {
        // здесь нечего логировать и соответсвенно это бесполезная вещь
        try
        {
            return int.Parse(str);
        }
        catch (Exception ex)
        {
            return 0;
        }
    }

    public int TryParse(string str)
    {
        int result;
        if (!int.TryParse(str, out result))
            result = 0;
        return result;
    }

    public int TryParseFixed(string str)
    {
        int.TryParse(str, out int result);
        return result;
    }
}
