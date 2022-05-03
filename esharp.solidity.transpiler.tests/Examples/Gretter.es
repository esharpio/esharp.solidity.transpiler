using "hardhat/console.es";

public contract Greeter
{
    public string Greet { get; set; }
    
    public Greeter(string _greeting)
    {
        console.writeline(`Deploying a Greeter with greeting:${_greeting}`);
        this.Greet = _greeting;
    }
}