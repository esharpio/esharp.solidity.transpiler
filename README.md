# esharp.solidity.transpiler

ESharp transpiler converts eSharp to Solidity


## Greeter.es

```csharp
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
```

## Greeter.sol
```
// SPDX-License-Identifier: Unlicense
pragma solidity ^0.8.0;

import "hardhat/console.sol";

contract Greeter {
    string private greeting;

    constructor(string memory _greeting) {
        console.log("Deploying a Greeter with greeting:", _greeting);
        greeting = _greeting;
    }

    function greet() public view returns (string memory) {
        return greeting;
    }

    function setGreeting(string memory _greeting) public {
        console.log("Changing greeting from '%s' to '%s'", greeting, _greeting);
        greeting = _greeting;
    }
}
```
