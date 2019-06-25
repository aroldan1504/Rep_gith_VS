namespace creacional_builder
{
    class CarBuilder : VehicleBuilder

    {
        public CarBuilder()
        {
            vehicle = new Vehicle("Automóvil");
        }

        public override void BuildFrame()
        {
            vehicle["frame"] = "Marco de auto";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "2500 cc";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "4";
        }
    }
}
