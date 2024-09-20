

using SmartHomeAutomationSystem;

public class Program
{

    public static void Main()
    {
        IMode mode = new AirConditionerNormalMode();
        IDevice device = new AirConditioner(mode);

        Command turnOn = new TurnOnDeviceCommand(device);
        Command setMode = new SetModeCommand(device, new AirConditionerAwayMode());
        Command applyMode = new ApplyModeCommand(device);
        Command turnOff = new TurnOffDeviceCommand(device);


        turnOn.Execute();
        setMode.Execute();
        applyMode.Execute();
        turnOff.Execute();


    }
}
