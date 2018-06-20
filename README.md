# Country Info Enum - Country infos in one enum

### Example usage

How to retrieve country name:
```csharp
// Return a string of the country name "Turkey"
Country.Info.Turkey.GetCountryName();
```
How to retrieve country code:
```csharp
// Return a string of the country name "TR"
Country.Info.Turkey.GetCountryCode();
```
How to retrieve country currency:
```csharp
// Return a string of the country name "Lira"
Country.Info.Turkey.GetCurrency();
```
How to retrieve country currency code:
```csharp
// Return a string of the country name "TLY"
Country.Info.Turkey.GetCurrencyCode();
```
How to retrieve country phone code:
```csharp
// Return a string of the country name "+90"
Country.Info.Turkey.GetPhoneCode();
```

You can also search for the enum by the country name.
```csharp
// Returns Info enum.
Country.GetEnum("Turkey").GetCountryName();
```
Or country code.
```csharp
// Returns Info enum
Country.GetEnum("TR").GetCountryName();
```

Copyright (c) 2015 Ugur Hasar 
