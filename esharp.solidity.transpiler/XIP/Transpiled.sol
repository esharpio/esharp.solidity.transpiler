// SPDX
pragma solidity 0.8.9;

import "./FixedPoint.sol";

contract Example {

    struct Fixed {
        uint256 value;
        uint256 radix;
    }

    function Add(uint256 a, uint256 b) public pure returns (uint256) {
        Fixed memory _a = Fixed(a, 10);
        Fixed memory _b = Fixed(b, 10);

        return _a.value + _b.value;
    }
}
