# Polish.NumberInWords
Friendly library to convert numbers to Polish words.

```c
Console.WriteLine(123.ToPolishWords());

// sto dwadzieścia trzy
```

Polish.NumberInWords offers following features:

### All 7 Polish cases: Nominative, Genitive, Dative, Accusative, Instrumental, Locative, Vocative

```c
15.ToPolishWords().Case(Case.Dative);

// piętnastu
```

### Genders: Masculine, Feminine, Neuter

```c
22.ToPolishWords().Gender(Gender.Feminine);

// dwadzieścia dwie
```

### Cardinal numbers (one, two...) and ordinal numbers (first, second...)
```c
9.ToPolishWords().Ordinal();
    
// dziewiąty
```

### Big numbers
```c
long.MaxValue.ToPolishWords();
    
// dziewięć trylionów dwieście dwadzieścia trzy biliardy trzysta siedemdziesiąt dwa biliony trzydzieści sześć miliardów osiemset pięćdziesiąt cztery miliony siedemset siedemdziesiąt pięć tysięcy osiemset siedem
```


### And mix everything together with fluent methods
```c
10286.ToPolishWords()
    .Case(Case.Genitive)
    .Ordinal()
    .Gender(Gender.Feminine);

// dziesięć tysięcy dwieście osiemdziesiątej szóstej
```

### Possibility to create a sentence depends of number denclension.
```c
var bikesCount = int.Parse(Console.ReadLine());

var bikeWord = new Phrase()
{
    AccusativeForm = "rower",
    PluralAccusativeForm = "rowery",
    PluralGenitiveForm = "rowerów"
};

var sentense = bikesCount.ToPolishWords()
    .Case(Case.Accusative)
    .Write(x => $"Wczoraj widziałem {x.Words} {x.GetPhraseAfterNumber(bikeWord)}");

Console.WriteLine(sentense);

// 1 - Wczoraj widziałem jeden rower
// 2 - Wczoraj widziałem dwa rowery
// 5 - Wczoraj widziałem pięć rowerów
```

## Others
See my others libraries:
- [Polish.CurrenciesInWords](https://github.com/Lskrzypek/Polish.CurrenciesInWords)
- [Polish.DatesInWords](https://github.com/Lskrzypek/Polish.DatesInWords)
