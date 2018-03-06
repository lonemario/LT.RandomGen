# LT.RandomGen
[![NuGet](https://img.shields.io/nuget/v/Nuget.Core.svg)](https://www.nuget.org/packages/LT.RandomGen)

Library which helps to generate random text, datetime, int, email with many options.

**_new features_**  Add functions for generate words and paragraphs in 19 languages (English, 
Croatian, Czech, Danish, Dutch, Estonian, Finnish, French, German, Hungarian, Irish, Italian,
Latin, Polish, Portuguese, Slovak, Slovene, Spanish, Swedish)

## Prerequisites

### .NETStandard 2.0



## Example 

```c#
//for string
var _string = RandomGenerator.GenericString(10);
//for email
var _email = RandomGenerator.GenericEmail();
//for paragraphs (return 10 paragraphs of things type in italian)
var _paragraphs = RandomGenerator.GenerateParagraphs(Data.Kinds.Things,10,Data.Languages.Italian);
...
```

### Authors

- [Mario Righi](http://www.mariorighi.com)

### License

This project is licensed under the [MIT License](https://choosealicense.com/licenses/mit/)