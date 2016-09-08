# SafeConvert

The SafeConvert is a .NET library used to convert data between data types safely.

Supports .NET 2.0 ( `#define NET20` or use [linqbridge](https://github.com/u0hz/linqbridge) ) and .NET 3.5+

It uses `System.Convert` to convert object, and uses `TryParse` to convert string.

And the api is just the same as `System.Convert` class.


### NOTE
Convert string "1" to bool will return `true`
```c#
var b = "1".ToBoolean(); // Print true
```

### Samples
Convert from string "1" to byte
```c#
var b = "1".ToByte(); // Print 1
```
Convert from string "10" to short
```c#
var s = "10".ToInt16(); // Print 10
```
Convert from string "100" to int
```c#
var i = "100".ToInt32(); // Print 100
```
Convert from string "1000" to long
```c#
var l = "1000".ToInt64(); // Print 1000
```
Convert from string "6.5" to float
```c#
var f = "6.5".ToSingle(); // Print 6.5
```
Convert from string "6.5" to decimal
```c#
var d = "6.5".ToDecimal(); // Print 6.5
```
Convert from string "6.5" to double
```c#
var d = "6.5".ToDouble(); // Print 6.5
```
Convert from string "2014-12-02 11:00:00" to DateTime
```c#
var dateTime = "2014-12-02 11:00:00".ToDateTime();
```
Each extension methods has the default value in case of failing to parse

E.g: convert from string "abc" to int using default value
```c#
var n = "abc".ToInt(10); // Print default value 10 because of failing to parse
```
