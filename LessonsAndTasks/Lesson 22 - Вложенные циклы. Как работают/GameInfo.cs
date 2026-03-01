/*
 * Author: Nikolay Dvurechensky
 * Site: https://sites.google.com/view/dvurechensky
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 марта 2026 16:36:30
 * Version: 1.0.194
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