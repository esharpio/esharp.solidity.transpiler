using "hardhat/console.es";

public contract Greeter
{
    public string Greet { get; set; }
    
    public Greeter(string _greeting)
    {
        Console.WriteLine(`Deploying a Greeter with greeting:${_greeting}`);
        this.Greet = _greeting;
    }

    public void setGreeting(string _greeting)
    {
        Console.WriteLine(`Changing the greeting to:${_greeting}`);
        this.Greet = _greeting;
    }
}