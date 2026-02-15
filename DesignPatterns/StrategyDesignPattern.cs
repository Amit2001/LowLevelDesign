public class Robot
{
    public static void Main(string[] args)
    {
        RobotContext robot1 = new RobotContext(new TalkableRobot(), new WalkableRobot(), new RunnableRobot());
        RobotContext robot2 = new RobotContext(new NonTalkableRobot(), new NonWalkableRobot(), new NonRunnableRobot());

        Console.WriteLine("Robot 1: "+"\n");
        robot1.Talk();
        robot1.Walk();
        robot1.Run();
        Console.WriteLine("\nRobot 2: " + "\n");
        robot2.Talk();
        robot2.Walk();
        robot2.Run();
    }
}

public class RobotContext
{
    private ITalkRobot talkRobot;
    private IWalkRobot walkRobot;
    private IRunRobot runRobot;

    public RobotContext(ITalkRobot talkRobot, IWalkRobot walkRobot, IRunRobot runRobot)
    {
        this.talkRobot = talkRobot;
        this.walkRobot = walkRobot;
        this.runRobot = runRobot;
    }

    public void Talk()
    {
        talkRobot.Talk();
    }

    public void Walk()
    {
        walkRobot.Walk();
    }

    public void Run()
    {
        runRobot.Run();
    }
}

public interface ITalkRobot
{
    void Talk();
}
public class TalkableRobot : ITalkRobot
{
    public void Talk()
    {
        Console.WriteLine("Hello, I am a robot who can talk!");
    }
}

public class NonTalkableRobot : ITalkRobot
{
    public void Talk()
    {
        Console.WriteLine("Hello, I am a robot who cannot talk!");
    }
}

public interface IWalkRobot
{
    void Walk();
}

public class WalkableRobot : IWalkRobot
{
    public void Walk()
    {
        Console.WriteLine("Hello, I am a robot who can walk!");
    }
}

public class NonWalkableRobot : IWalkRobot
{
    public void Walk()
    {
        Console.WriteLine("Hello, I am a robot who cannot walk!");
    }
}

public interface IRunRobot
{
    void Run();
}

public class RunnableRobot : IRunRobot
{
    public void Run()
    {
        Console.WriteLine("Hello, I am a robot who can run!");
    }
}

public class NonRunnableRobot : IRunRobot
{
    public void Run()
    {
        Console.WriteLine("Hello, I am a robot who cannot run!");
    }
}