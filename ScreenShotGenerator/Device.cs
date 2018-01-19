namespace ScreenShotGenerator
{
    public class Device
    {
        public string Name, Type;



        public Device(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public override string ToString()
        {
            return Name + "\t " + Type;
        }
    }
}
