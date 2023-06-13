using OOPAdventure;

public class English : Language
{
    public English()
    {
        ChooseYourName = "Hello, what is your name?";
        DefaultName = "Tony";
        Welcome = "Welcome, {0}, to your OOP Adventure!";
        DefaultRoomName = "Room {0} {1},{2}";
        DefaultRoomDescription = "You are in a room with doors to the {0}.";
        ActionError = "You can't do that.";
        Go = "Go";
        GoError = "You can't go that way.";
        WhatToDo = "What you want to do?";
        Quit = "quit";
    }
}
