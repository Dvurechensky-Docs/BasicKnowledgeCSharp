/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 30 мая 2026 15:42:03
 * Version: 1.0.286
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