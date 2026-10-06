/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 06 октября 2026 09:56:36
 * Version: 1.0.416
 */

using System.Collections.Generic;

public class GameInfo
{
    public GameType TypeOfGame { get; set; }

    public List<Game> Games { get; set; }
}

public enum GameType
{
    RPG,
    Shooter,
    Strategy
}