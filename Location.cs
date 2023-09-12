public class Location
{
    public int ID;
    public string Location_Name;
    public string Location_Description;
    public string Location_Unlock_Requirements;
    public bool Location_Unlocked;
    public List<Quest> QuestAvailableHere = new List<Quest>();

    public Location LocationToNorth = null;
    public Location LocationToSouth = null;
    public Location LocationToEast = null;
    public Location LocationToWest = null;
    public Monster MonsterLivingHere = null;

    public Location(int Location_ID, string Location_Name, string Location_Description, string Location_Unlock_Requirements, string Location_Unlocked)
    {
        this.ID = Location_ID;
        this.Location_Name = Location_Name;
        this.Location_Description = Location_Description;

        this.Location_Unlock_Requirements = Location_Unlock_Requirements;
        if (Location_Unlocked is null)
        {
            this.Location_Unlocked = true;
        }
        else if (Location_Unlocked == "n")
        {
            this.Location_Unlocked = false;
        }
    }
    public bool OfferQuest(Quest quest)
    {
        Console.WriteLine($"You are at {Location_Name}.");
        Console.WriteLine(Location_Description);
        Console.WriteLine();
        Console.WriteLine(quest.Quest_Name);
        Console.WriteLine(quest.Quest_Goal);
        Console.WriteLine("Would you like to accept the available quest? (yes/no)");
        string choice = Console.ReadLine().ToLower();

        if (choice == "yes")
        {
            Console.WriteLine($"You have accepted the quest: {quest.Quest_Name}");
            return true;
        }


        return false;
    }

}
