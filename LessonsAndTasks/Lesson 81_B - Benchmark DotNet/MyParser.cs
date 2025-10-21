﻿/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 октября 2025 14:24:57
 * Version: 1.0.63
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
