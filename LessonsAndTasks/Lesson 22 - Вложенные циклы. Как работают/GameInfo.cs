/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 августа 2026 06:51:04
 * Version: 1.0.380
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