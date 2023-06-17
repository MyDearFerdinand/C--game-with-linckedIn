﻿using OOPAdventure;

public class English : Language
{
    public English()
    {
        ChooseYourName = "Hello, what is your name?";
        DefaultName = "Tony";
        Welcome = "Welcome, {0}, to your OOP Adventure!";
        DefaultRoomName = "Room {0} {1},{2}";
        DefaultRoomDescription = " You are in a {0} room with doors to the {1}.";
        ActionError = "You can't do that.";
        Go = "Go";
        GoError = "You can't go that way.";
        WhatToDo = "What you want to do?";
        Quit = "quit";
        RoomNew = "You entered {0}.";
        RoomOld = "You return to {0}.";
        And = "and";
        Comma = ",";
        Space = " ";
        RoomDescriptions = new List<string> {
            "normal",
            "cold",
            "warm",
            "dark",
            "scary",
            "bright",
            "strange"
        };
        NoItem = "You don't have {0}.";
        Backpack = "Backpack";
        BackpackError = "You don't haave anything in backpack";
        BackpackDescription = "Your backpack contains: {0}";
        Chest = "chest";
        UnlockChest = "You unlocked the chest.";
        Key = "key";
        ChestEmpty = "This chest is empty";
        ChestFound = "You found: {0}";
    }
}
