// SPX
pragma solidity 0.8.9;

library XIP4 {

    function removeItem(address[] storage items, uint256 index) external returns(address[] storage) {
        uint256 length = items.length;
        if (index >= length) return items;

        for (uint256 i = index; i < length - 1; i++){
            items[i] = items[i+1];
        }

        items.pop();

        return items;
    }
}

contract Example {
    function Foo() public {
        address[] storage _items;
        _items = XIP4.removeItem(_items, 0);
    }
}