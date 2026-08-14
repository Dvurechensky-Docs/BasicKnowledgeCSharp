/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 августа 2026 08:15:21
 * Version: 1.0.363
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