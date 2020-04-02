namespace OOP
{
    public abstract class HouseholdAppliance
    {
        private readonly string _name;
        private readonly int _voltage;
        protected HouseholdAppliance(string name, int voltage)
        {
            _name = name;
            _voltage = voltage;
        }

        //The goal is to provide generic behaviours and let the concrete class provide especialize behaviours,
        //that is, Create generic concepts that can be abstracted by other classes.

        public abstract void TurnOn();
        public abstract void TurnOff();

        public virtual void Test()
        {
            // Equipment Test
        }
    }
}
