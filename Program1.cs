using System;
class Program1
{
    static void Main()
    {
        // Create a machine-level variable (requires admin rights)
        Environment.SetEnvironmentVariable("MyMachineVar", "MachineValue", EnvironmentVariableTarget.Machine);
    }
}