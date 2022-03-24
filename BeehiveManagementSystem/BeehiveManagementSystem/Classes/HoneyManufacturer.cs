namespace BeehiveManagementSystem.Classes
{
    class HoneyManufacturer : Bee
    {
        public const float NECTAR_PROSSESED_PER_SHIFT = 33.15f;
        public override float CostPerShift { get { return 1.7f; } }
        public HoneyManufacturer() : base("Honey Manufacturer") { }

        protected override void DoJob()
        {
            HoneyVault.ConvertNectarToHoney(NECTAR_PROSSESED_PER_SHIFT);
        }
    }
}
