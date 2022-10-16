namespace DesignPatterns.Builder
{
	public class Director
    {
        private Builder builder = null;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public Computer AssembleComputer()
        {
            builder.BuildCPU();
            builder.BuildDisk();
            builder.BuildGraphicsCard();
            builder.BuildMainBoard();
            builder.BuildMemory();
            return builder.CreateComputer();
        }
    }
}
