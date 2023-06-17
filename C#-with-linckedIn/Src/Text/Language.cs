using System.Text;

namespace OOPAdventure;

public abstract partial class Language
{
    private readonly StringBuilder _sb = new();

    public virtual string JoinedWordList(string[] words, string conjunction)
    {
        _sb.Clear();

        for (var i = 0; i < words.Length; i++)
        {
            if (i > 0)
            {
                _sb.Append(words.Length > 2 ? Comma + Space : Space);
            }
            else if (i == words.Length - 1 && words.Length > 1)
            {
                _sb.Append(conjunction + Space);
            }
            _sb.Append(words[i]);
        }
        return _sb.ToString();
    }
    public string Welcome { get; protected set; } = "";
    public string ChooseYourName { get; protected set; } = "";
    public string DefaultName { get; protected set; } = "";
    public string DefaultRoomName { get; protected set; } = "";
    public string DefaultRoomDescription { get; protected set; } = "";
    public string ActionError { get; protected set; } = "";
    public string Go { get; protected set; } = "";
    public string GoError { get; protected set; } = "";
    public string WhatToDo { get; protected set; } = "";
    public string Quit { get; protected set; } = "";
    public string RoomNew { get; protected set; } = "";
    public string RoomOld { get; protected set; } = "";
    public string And { get; protected set; } = "";
    public string Comma { get; protected set; } = "";
    public string Space { get; protected set; } = "";
    public List<string> RoomDescriptions { get; protected set; }
    public string NoItem { get; protected set; } = "";
    public string Backpack { get; protected set; } = "";
    public string BackpackError { get; protected set; } = "";
    public string BackpackDescription { get; protected set; } = "";
    public string Chest { get; protected set; } = "";
    public string UnlockChest { get; protected set; } = "";
    public string Key { get; protected set; } = "";
    public string ChestEmpty { get; protected set; } = "";
    public string ChestFound { get; protected set; } = "";
}