using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryInfoEnum
{
  public static class Country
  {
    public enum Info
    {
      [CountryInfo(Code = "Unknown", Name = "Unknown", Currency = "", CurrencyCode = "", PhoneCode = "")]
      Unknown = 0,
      [CountryInfo(Code = "AF", Name = "Afghanistan", Currency = "Afghani", CurrencyCode = "AFA", PhoneCode = "+93")]
      Afghanistan = 1,
      [CountryInfo(Code = "DZ", Name = "Algeria", Currency = "Dinar", CurrencyCode = "DZD", PhoneCode = "+213")]
      Algeria = 2,
      [CountryInfo(Code = "AD", Name = "Andorra", Currency = "Franc", CurrencyCode = "ADF", PhoneCode = "+376")]
      Andorra = 3,
      [CountryInfo(Code = "AO", Name = "Angola", Currency = "New Kwanza", CurrencyCode = "AON", PhoneCode = "+244")]
      Angola = 4,
      [CountryInfo(Code = "AQ", Name = "Antarctica", Currency = "", CurrencyCode = "", PhoneCode = "+672")]
      Antarctica = 5,
      [CountryInfo(Code = "AR", Name = "Argentina", Currency = "Peso ", CurrencyCode = "ARS", PhoneCode = "+54")]
      Argentina = 6,
      [CountryInfo(Code = "AM", Name = "Armenia", Currency = "", CurrencyCode = "", PhoneCode = "+374")]
      Armenia = 7,
      [CountryInfo(Code = "AW", Name = "Aruba", Currency = "Florin ", CurrencyCode = "AWG", PhoneCode = "+297")]
      Aruba = 8,
      [CountryInfo(Code = "AU", Name = "Australia", Currency = "Dollar", CurrencyCode = "AUD", PhoneCode = "+61")]
      Australia = 9,
      [CountryInfo(Code = "AT", Name = "Austria", Currency = "Schilling", CurrencyCode = "ATS", PhoneCode = "+43")]
      Austria = 10,
      [CountryInfo(Code = "AZ", Name = "Azerbaijan", Currency = "", CurrencyCode = "", PhoneCode = "+994")]
      Azerbaijan = 11,
      [CountryInfo(Code = "BH", Name = "Bahrain", Currency = "Dinar", CurrencyCode = "BHD", PhoneCode = "+973")]
      Bahrain = 12,
      [CountryInfo(Code = "BD", Name = "Bangladesh", Currency = "Taka", CurrencyCode = "BDT", PhoneCode = "+880")]
      Bangladesh = 13,
      [CountryInfo(Code = "BY", Name = "Belarus", Currency = "", CurrencyCode = "", PhoneCode = "+375")]
      Belarus = 14,
      [CountryInfo(Code = "BE", Name = "Belgium", Currency = "Franc", CurrencyCode = "BEF", PhoneCode = "+32")]
      Belgium = 15,
      [CountryInfo(Code = "BZ", Name = "Belize", Currency = "Dollar", CurrencyCode = "BZD", PhoneCode = "+501")]
      Belize = 16,
      [CountryInfo(Code = "BJ", Name = "Benin", Currency = "CFA Franc ", CurrencyCode = "XOF", PhoneCode = "+229")]
      Benin = 17,
      [CountryInfo(Code = "BT", Name = "Bhutan", Currency = "Ngultrum", CurrencyCode = "BTN", PhoneCode = "+975")]
      Bhutan = 18,
      [CountryInfo(Code = "BO", Name = "Plurinational State Of Bolivia", Currency = "Boliviano", CurrencyCode = "BOB", PhoneCode = "+591")]
      Bolivia = 19,
      [CountryInfo(Code = "BA", Name = "Bosnia And Herzegovina", Currency = "", CurrencyCode = "", PhoneCode = "+387")]
      BosniaHerzegovina = 20,
      [CountryInfo(Code = "BW", Name = "Botswana", Currency = "Pula", CurrencyCode = "BWP", PhoneCode = "+267")]
      Botswana = 21,
      [CountryInfo(Code = "BR", Name = "Brazil", Currency = "Cruzeiro", CurrencyCode = "BRC", PhoneCode = "+55")]
      Brazil = 22,
      [CountryInfo(Code = "BN", Name = "Brunei Darussalam", Currency = "Dollar", CurrencyCode = "BND", PhoneCode = "+673")]
      BruneiDarussalam = 23,
      [CountryInfo(Code = "BG", Name = "Bulgaria", Currency = "Lev", CurrencyCode = "BGL", PhoneCode = "+359")]
      Bulgaria = 24,
      [CountryInfo(Code = "BF", Name = "Burkina Faso", Currency = "CFA Franc ", CurrencyCode = "XOF", PhoneCode = "+226")]
      BurkinaFaso = 25,
      [CountryInfo(Code = "BI", Name = "Burundi", Currency = "Franc", CurrencyCode = "BIF", PhoneCode = "+257")]
      Burundi = 26,
      [CountryInfo(Code = "KH", Name = "Cambodia", Currency = "Riel ", CurrencyCode = "KHR", PhoneCode = "+855")]
      Cambodia = 27,
      [CountryInfo(Code = "CM", Name = "Cameroon", Currency = "CFA Franc ", CurrencyCode = "XAF", PhoneCode = "+237")]
      Cameroon = 28,
      [CountryInfo(Code = "CA", Name = "Canada", Currency = "Dollar", CurrencyCode = "CAD", PhoneCode = "+1")]
      Canada = 29,
      [CountryInfo(Code = "CV", Name = "Cape Verde", Currency = "Escudo", CurrencyCode = "CVE", PhoneCode = "+238")]
      CapeVerde = 30,
      [CountryInfo(Code = "CF", Name = "Central African Republic", Currency = "CFA Franc ", CurrencyCode = "XAF", PhoneCode = "+236")]
      CentralAfricanRepubliC = 31,
      [CountryInfo(Code = "TD", Name = "Chad", Currency = "CFA Franc BEAC", CurrencyCode = "XAF", PhoneCode = "+235")]
      Chad = 32,
      [CountryInfo(Code = "CL", Name = "Chile", Currency = "Peso", CurrencyCode = "CLP", PhoneCode = "+56")]
      Chile = 33,
      [CountryInfo(Code = "CN", Name = "China", Currency = "Yuan Renminbi", CurrencyCode = "CNY", PhoneCode = "+86")]
      China = 34,
      [CountryInfo(Code = "CX", Name = "Christmas Island", Currency = "", CurrencyCode = "", PhoneCode = "+61")]
      ChristmasIsland = 35,
      [CountryInfo(Code = "CC", Name = "Cocos (keeling) Islands", Currency = "", CurrencyCode = "", PhoneCode = "+61")]
      CocosIslands = 36,
      [CountryInfo(Code = "CO", Name = "Colombia", Currency = "Peso", CurrencyCode = "COP", PhoneCode = "+57")]
      Colombia = 37,
      [CountryInfo(Code = "KM", Name = "Comoros", Currency = "Franc", CurrencyCode = "KMF", PhoneCode = "+269")]
      Comoros = 38,
      [CountryInfo(Code = "CG", Name = "Congo", Currency = "CFA Franc BEAC", CurrencyCode = "XAF", PhoneCode = "+242")]
      Congo = 39,
      [CountryInfo(Code = "CD", Name = "The Democratic Republic Of The Congo", Currency = "", CurrencyCode = "", PhoneCode = "+243")]
      DemocraticRepublicConGO = 40,
      [CountryInfo(Code = "CK", Name = "Cook Islands", Currency = "", CurrencyCode = "", PhoneCode = "+682")]
      CookIslands = 41,
      [CountryInfo(Code = "CR", Name = "Costa Rica", Currency = "Colon", CurrencyCode = "CRC", PhoneCode = "+506")]
      CostaRica = 42,
      [CountryInfo(Code = "HR", Name = "Croatia", Currency = "Kuna", CurrencyCode = "HRK", PhoneCode = "+385")]
      Croatia = 43,
      [CountryInfo(Code = "CU", Name = "Cuba", Currency = "Peso", CurrencyCode = "CUP", PhoneCode = "+53")]
      Cuba = 44,
      [CountryInfo(Code = "CY", Name = "Cyprus", Currency = "Pound", CurrencyCode = "CVP", PhoneCode = "+357")]
      Cyprus = 45,
      [CountryInfo(Code = "CZ", Name = "Czech Republic", Currency = "Koruna", CurrencyCode = "CSK", PhoneCode = "+420")]
      CzechRepublic = 46,
      [CountryInfo(Code = "DK", Name = "Denmark", Currency = "Guilder", CurrencyCode = "DKK", PhoneCode = "+45")]
      Denmark = 47,
      [CountryInfo(Code = "DJ", Name = "Djibouti", Currency = "Franc", CurrencyCode = "DJF", PhoneCode = "+253")]
      Djibouti = 48,
      [CountryInfo(Code = "EC", Name = "Ecuador", Currency = "Sucre", CurrencyCode = "ECS", PhoneCode = "+593")]
      Ecuador = 49,
      [CountryInfo(Code = "EG", Name = "Egypt", Currency = "Pound", CurrencyCode = "EGP", PhoneCode = "+20")]
      Egypt = 50,
      [CountryInfo(Code = "SV", Name = "El Salvador", Currency = "Colon", CurrencyCode = "SVC", PhoneCode = "+503")]
      ElSalvador = 51,
      [CountryInfo(Code = "GQ", Name = "Equatorial Guinea", Currency = "CFA ", CurrencyCode = "XAF", PhoneCode = "+240")]
      EquatorialGuinea = 52,
      [CountryInfo(Code = "ER", Name = "Eritrea", Currency = "", CurrencyCode = "", PhoneCode = "+291")]
      Eritrea = 53,
      [CountryInfo(Code = "EE", Name = "Estonia", Currency = "Kroon", CurrencyCode = "EEK", PhoneCode = "+372")]
      Estonia = 54,
      [CountryInfo(Code = "ET", Name = "Ethiopia", Currency = "Birr", CurrencyCode = "ETB", PhoneCode = "+251")]
      Ethiopia = 55,
      [CountryInfo(Code = "FK", Name = "Falkland Islands", Currency = "Pound", CurrencyCode = "FKP", PhoneCode = "+500")]
      FalklandIslands4FverBRItish = 56,
      [CountryInfo(Code = "FO", Name = "Faroe Islands", Currency = "", CurrencyCode = "", PhoneCode = "+298")]
      FaroeIslands = 57,
      [CountryInfo(Code = "FJ", Name = "Fiji", Currency = "Dollar", CurrencyCode = "FJD", PhoneCode = "+679")]
      Fiji = 58,
      [CountryInfo(Code = "FI", Name = "Finland", Currency = "Markka", CurrencyCode = "FIM", PhoneCode = "+358")]
      Finland = 59,
      [CountryInfo(Code = "FR", Name = "France", Currency = "Franc", CurrencyCode = "FRF", PhoneCode = "+33")]
      France = 60,
      [CountryInfo(Code = "GA", Name = "Gabon", Currency = "CFA Franc BEAC", CurrencyCode = "XAF", PhoneCode = "+241")]
      Gabon = 61,
      [CountryInfo(Code = "GM", Name = "Gambia", Currency = "Dalasi", CurrencyCode = "GMD", PhoneCode = "+220")]
      Gambia = 62,
      [CountryInfo(Code = "GE", Name = "Georgia", Currency = "", CurrencyCode = "", PhoneCode = "+995")]
      Georgia = 63,
      [CountryInfo(Code = "DE", Name = "Germany", Currency = "Mark", CurrencyCode = "DEM", PhoneCode = "+49")]
      Germany = 64,
      [CountryInfo(Code = "GH", Name = "Ghana", Currency = "Cedi", CurrencyCode = "GHC", PhoneCode = "+233")]
      Ghana = 65,
      [CountryInfo(Code = "GI", Name = "Gibraltar", Currency = "Pound", CurrencyCode = "GIP", PhoneCode = "+350")]
      Gibraltar = 66,
      [CountryInfo(Code = "GB", Name = "United Kingdom", Currency = "Sterling", CurrencyCode = "GBP", PhoneCode = "+44")]
      UnitedKingdom = 67,
      [CountryInfo(Code = "GR", Name = "Greece", Currency = "Drachma", CurrencyCode = "GRD", PhoneCode = "+30")]
      Greece = 68,
      [CountryInfo(Code = "GL", Name = "Greenland", Currency = "", CurrencyCode = "", PhoneCode = "+299")]
      Greenland = 69,
      [CountryInfo(Code = "GT", Name = "Guatemala", Currency = "Quetzal", CurrencyCode = "GTQ", PhoneCode = "+502")]
      Guatemala = 70,
      [CountryInfo(Code = "GN", Name = "Guinea", Currency = "Franc", CurrencyCode = "GNF", PhoneCode = "+224")]
      Guinea = 71,
      [CountryInfo(Code = "GW", Name = "Guinea-bissau", Currency = "Peso", CurrencyCode = "GWP", PhoneCode = "+245")]
      Guineabissau = 72,
      [CountryInfo(Code = "GY", Name = "Guyana", Currency = "Dollar", CurrencyCode = "GYD", PhoneCode = "+592")]
      Guyana = 73,
      [CountryInfo(Code = "HT", Name = "Haiti", Currency = "Gourde", CurrencyCode = "HTG", PhoneCode = "+509")]
      Haiti = 74,
      [CountryInfo(Code = "VA", Name = "Vatican City", Currency = "", CurrencyCode = "", PhoneCode = "+39")]
      vaticanCity = 75,
      [CountryInfo(Code = "HN", Name = "Honduras", Currency = "Lempira", CurrencyCode = "HNL", PhoneCode = "+504")]
      Honduras = 76,
      [CountryInfo(Code = "HK", Name = "Hong Kong", Currency = "Dollar", CurrencyCode = "HKD", PhoneCode = "+852")]
      HongKong = 77,
      [CountryInfo(Code = "HU", Name = "Hungary", Currency = "Forint", CurrencyCode = "HUF", PhoneCode = "+36")]
      Hungary = 78,
      [CountryInfo(Code = "IN", Name = "India", Currency = "Rupee", CurrencyCode = "INR", PhoneCode = "+91")]
      India = 79,
      [CountryInfo(Code = "ID", Name = "Indonesia", Currency = "Rupiah", CurrencyCode = "IDR", PhoneCode = "+62")]
      Indonesia = 80,
      [CountryInfo(Code = "IR", Name = "Islamic Republic Of Iran", Currency = "Rial", CurrencyCode = "IRR", PhoneCode = "+98")]
      Iran = 81,
      [CountryInfo(Code = "IQ", Name = "Iraq", Currency = "Dinar", CurrencyCode = "IQD", PhoneCode = "+964")]
      Iraq = 82,
      [CountryInfo(Code = "IE", Name = "Ireland", Currency = "Punt", CurrencyCode = "IEP", PhoneCode = "+353")]
      Ireland = 83,
      [CountryInfo(Code = "IL", Name = "Israel", Currency = "New Shekel", CurrencyCode = "ILS", PhoneCode = "+972")]
      Israel = 84,
      [CountryInfo(Code = "IT", Name = "Italy", Currency = "Lira", CurrencyCode = "ITL", PhoneCode = "+39")]
      Italy = 85,
      [CountryInfo(Code = "CI", Name = "Côte D'ivoire", Currency = "", CurrencyCode = "", PhoneCode = "+225")]
      CoteDivoire = 86,
      [CountryInfo(Code = "JP", Name = "Japan", Currency = "Yen", CurrencyCode = "JPY", PhoneCode = "+81")]
      Japan = 87,
      [CountryInfo(Code = "JO", Name = "Jordan", Currency = "Dinar", CurrencyCode = "JOD", PhoneCode = "+962")]
      Jordan = 88,
      [CountryInfo(Code = "KE", Name = "Kenya", Currency = "Schilling", CurrencyCode = "KES", PhoneCode = "+254")]
      Kenya = 89,
      [CountryInfo(Code = "KI", Name = "Kiribati", Currency = "", CurrencyCode = "", PhoneCode = "+686")]
      Kiribati = 90,
      [CountryInfo(Code = "KW", Name = "Kuwait", Currency = "Dinar", CurrencyCode = "KWD", PhoneCode = "+965")]
      Kuwait = 91,
      [CountryInfo(Code = "KG", Name = "Kyrgyzstan", Currency = "", CurrencyCode = "", PhoneCode = "+996")]
      Kyrgyzstan = 92,
      [CountryInfo(Code = "LA", Name = "Lao People's Democratic Republic", Currency = "Kip", CurrencyCode = "LAK", PhoneCode = "+856")]
      LaoPeoplesDR = 93,
      [CountryInfo(Code = "LV", Name = "Latvia", Currency = "Lats", CurrencyCode = "LVL", PhoneCode = "+371")]
      Latvia = 94,
      [CountryInfo(Code = "LB", Name = "Lebanon", Currency = "Pound", CurrencyCode = "LBP", PhoneCode = "+961")]
      Lebanon = 95,
      [CountryInfo(Code = "LS", Name = "Lesotho", Currency = "Loti", CurrencyCode = "LSL", PhoneCode = "+266")]
      Lesotho = 96,
      [CountryInfo(Code = "LR", Name = "Liberia", Currency = " Dollar", CurrencyCode = "LRD", PhoneCode = "+231")]
      Liberia = 97,
      [CountryInfo(Code = "LY", Name = "Libya", Currency = "Dinar", CurrencyCode = "LYD", PhoneCode = "+218")]
      Libya = 98,
      [CountryInfo(Code = "LI", Name = "Liechtenstein", Currency = "", CurrencyCode = "", PhoneCode = "+423")]
      Liechtenstein = 99,
      [CountryInfo(Code = "LT", Name = "Lithuania", Currency = "Litas", CurrencyCode = "LTL", PhoneCode = "+370")]
      Lithuania = 100,
      [CountryInfo(Code = "LU", Name = "Luxembourg", Currency = "Franc", CurrencyCode = "LUF", PhoneCode = "+352")]
      Luxembourg = 101,
      [CountryInfo(Code = "MO", Name = "Macao", Currency = "Pataca", CurrencyCode = "MOP", PhoneCode = "+853")]
      Macao = 102,
      [CountryInfo(Code = "MK", Name = "Macedonia", Currency = "", CurrencyCode = "", PhoneCode = "+389")]
      Macedonia = 103,
      [CountryInfo(Code = "MG", Name = "Madagascar", Currency = "", CurrencyCode = "", PhoneCode = "+261")]
      Madagascar = 104,
      [CountryInfo(Code = "MW", Name = "Malawi", Currency = "Kwacha", CurrencyCode = "MWK", PhoneCode = "+265")]
      Malawi = 105,
      [CountryInfo(Code = "MY", Name = "Malaysia", Currency = "Ringgit", CurrencyCode = "MYR", PhoneCode = "+60")]
      Malaysia = 106,
      [CountryInfo(Code = "MV", Name = "Maldives", Currency = "Rufiyaa", CurrencyCode = "MVR", PhoneCode = "+960")]
      Maldives = 107,
      [CountryInfo(Code = "ML", Name = "Mali", Currency = "CFA Franc BCEAO", CurrencyCode = "XOF", PhoneCode = "+223")]
      Mali = 108,
      [CountryInfo(Code = "MT", Name = "Malta", Currency = "Lira", CurrencyCode = "MTL", PhoneCode = "+356")]
      Malta = 109,
      [CountryInfo(Code = "MR", Name = "Mauritania", Currency = "Ouguiya", CurrencyCode = "MRO", PhoneCode = "+222")]
      Mauritania = 110,
      [CountryInfo(Code = "MU", Name = "Mauritius", Currency = "Rupee", CurrencyCode = "MUR", PhoneCode = "+230")]
      Mauritius = 111,
      [CountryInfo(Code = "YT", Name = "Mayotte", Currency = "", CurrencyCode = "", PhoneCode = "+262")]
      Mayotte = 112,
      [CountryInfo(Code = "MX", Name = "Mexico", Currency = "Peso", CurrencyCode = "MXP", PhoneCode = "+52")]
      Mexico = 113,
      [CountryInfo(Code = "FM", Name = "Federated States Of Micronesia", Currency = "", CurrencyCode = "", PhoneCode = "+691")]
      Micronesia = 114,
      [CountryInfo(Code = "MD", Name = "Republic Of Moldova", Currency = "", CurrencyCode = "", PhoneCode = "+373")]
      Moldova = 115,
      [CountryInfo(Code = "MC", Name = "Monaco", Currency = "", CurrencyCode = "", PhoneCode = "+377")]
      Monaco = 116,
      [CountryInfo(Code = "MN", Name = "Mongolia", Currency = "Tugrik", CurrencyCode = "MNT", PhoneCode = "+976")]
      Mongolia = 117,
      [CountryInfo(Code = "MA", Name = "Morocco", Currency = "Dirham", CurrencyCode = "MAD", PhoneCode = "+212")]
      Morocco = 118,
      [CountryInfo(Code = "MZ", Name = "Mozambique", Currency = "Metical", CurrencyCode = "MZM", PhoneCode = "+258")]
      Mozambique = 119,
      [CountryInfo(Code = "MM", Name = "Myanmar", Currency = "Kyat", CurrencyCode = "MMK", PhoneCode = "+95")]
      Myanmar = 120,
      [CountryInfo(Code = "NA", Name = "Namibia", Currency = "", CurrencyCode = "", PhoneCode = "+264")]
      Namibia = 121,
      [CountryInfo(Code = "NR", Name = "Nauru", Currency = "", CurrencyCode = "", PhoneCode = "+674")]
      Nauru = 122,
      [CountryInfo(Code = "NP", Name = "Nepal", Currency = "", CurrencyCode = "", PhoneCode = "+977")]
      Nepal = 123,
      [CountryInfo(Code = "NL", Name = "Netherlands", Currency = "Guilder", CurrencyCode = "NLG", PhoneCode = "+31")]
      Netherlands = 124,
      [CountryInfo(Code = "NC", Name = "New Caledonia", Currency = "", CurrencyCode = "", PhoneCode = "+687")]
      NewCaledonia = 125,
      [CountryInfo(Code = "NZ", Name = "New Zealand", Currency = "Dollar", CurrencyCode = "NZD", PhoneCode = "+64")]
      NewZealand = 126,
      [CountryInfo(Code = "NI", Name = "Nicaragua", Currency = "Cordoba Oro", CurrencyCode = "NIO", PhoneCode = "+505")]
      Nicaragua = 127,
      [CountryInfo(Code = "NE", Name = "Niger", Currency = "CFA Franc", CurrencyCode = "XOF", PhoneCode = "+227")]
      Niger = 128,
      [CountryInfo(Code = "NG", Name = "Nigeria", Currency = "Naira", CurrencyCode = "NGN", PhoneCode = "+234")]
      Nigeria = 129,
      [CountryInfo(Code = "NU", Name = "Niue", Currency = "", CurrencyCode = "", PhoneCode = "+683")]
      Niue = 130,
      [CountryInfo(Code = "KP", Name = "Democratic People's Republic Of Korea", Currency = "Won", CurrencyCode = "KPW", PhoneCode = "+850")]
      NorthKorea = 131,
      [CountryInfo(Code = "NO", Name = "Norway", Currency = "Kroner", CurrencyCode = "NOK", PhoneCode = "+47")]
      Norway = 132,
      [CountryInfo(Code = "OM", Name = "Oman", Currency = "Rial", CurrencyCode = "OMR", PhoneCode = "+968")]
      Oman = 133,
      [CountryInfo(Code = "PK", Name = "Pakistan", Currency = "Rupee", CurrencyCode = "PKR", PhoneCode = "+92")]
      Pakistan = 134,
      [CountryInfo(Code = "PW", Name = "Palau", Currency = "oz", CurrencyCode = "XPD", PhoneCode = "+680")]
      Palau = 135,
      [CountryInfo(Code = "PA", Name = "Panama", Currency = "Balboa", CurrencyCode = "PAB", PhoneCode = "+507")]
      Panama = 136,
      [CountryInfo(Code = "PG", Name = "Papua New Guinea", Currency = "Kina", CurrencyCode = "PGK", PhoneCode = "+675")]
      PapuaNewGuinea = 137,
      [CountryInfo(Code = "PY", Name = "Paraguay", Currency = "Guarani", CurrencyCode = "PYG", PhoneCode = "+595")]
      Paraguay = 138,
      [CountryInfo(Code = "PE", Name = "Peru", Currency = "Neuevo Sol", CurrencyCode = "PEN", PhoneCode = "+51")]
      Peru = 139,
      [CountryInfo(Code = "PN", Name = "Pitcairn", Currency = "", CurrencyCode = "", PhoneCode = "+870")]
      Pitcairn = 140,
      [CountryInfo(Code = "PL", Name = "Poland", Currency = "Zloty", CurrencyCode = "PLZ", PhoneCode = "+48")]
      Poland = 141,
      [CountryInfo(Code = "PF", Name = "French Polynesia", Currency = "", CurrencyCode = "", PhoneCode = "+689")]
      FrenchPolynesia = 142,
      [CountryInfo(Code = "PT", Name = "Portugal", Currency = "Escudo", CurrencyCode = "PTE", PhoneCode = "+351")]
      Portugal = 143,
      [CountryInfo(Code = "PR", Name = "Puerto Rico", Currency = "", CurrencyCode = "", PhoneCode = "+1")]
      PuertoRico = 144,
      [CountryInfo(Code = "QA", Name = "Qatar", Currency = "Rial", CurrencyCode = "QAR", PhoneCode = "+974")]
      Qatar = 145,
      [CountryInfo(Code = "RO", Name = "Romania", Currency = "Leu", CurrencyCode = "ROL", PhoneCode = "+40")]
      Romania = 146,
      [CountryInfo(Code = "RU", Name = "Russian Federation", Currency = "Rouble", CurrencyCode = "RUB", PhoneCode = "+7")]
      RussianFederation = 147,
      [CountryInfo(Code = "RW", Name = "Rwanda", Currency = "", CurrencyCode = "", PhoneCode = "+250")]
      Rwanda = 148,
      [CountryInfo(Code = "SH", Name = "Saint Helena, Ascension And Tristan Da Cunha", Currency = "", CurrencyCode = "", PhoneCode = "+290")]
      SaintHelena = 149,
      [CountryInfo(Code = "PM", Name = "Saint Pierre And Miquelon", Currency = "", CurrencyCode = "", PhoneCode = "+508")]
      SaintPierreMiquelon = 150,
      [CountryInfo(Code = "ST", Name = "Sao Tome And Principe", Currency = "", CurrencyCode = "", PhoneCode = "+239")]
      SaoTomeAndPrincipe = 151,
      [CountryInfo(Code = "WS", Name = "Samoa", Currency = "Tala", CurrencyCode = "WST", PhoneCode = "+685")]
      Samoa = 152,
      [CountryInfo(Code = "SM", Name = "San Marino", Currency = "", CurrencyCode = "", PhoneCode = "+378")]
      SanMarino = 153,
      [CountryInfo(Code = "SA", Name = "Saudi Arabia", Currency = "Riyal", CurrencyCode = "SAR", PhoneCode = "+966")]
      SaudiArabia = 154,
      [CountryInfo(Code = "SN", Name = "Senegal", Currency = "CFA Franc ", CurrencyCode = "XOF", PhoneCode = "+221")]
      Senegal = 155,
      [CountryInfo(Code = "SC", Name = "Seychelles", Currency = "Rupee", CurrencyCode = "SCR", PhoneCode = "+248")]
      Seychelles = 156,
      [CountryInfo(Code = "SL", Name = "Sierra Leone", Currency = "Leone", CurrencyCode = "SLL", PhoneCode = "+232")]
      SierraLeone = 157,
      [CountryInfo(Code = "SG", Name = "Singapore", Currency = "Dollar", CurrencyCode = "SGD", PhoneCode = "+65")]
      Singapore = 158,
      [CountryInfo(Code = "SK", Name = "Slovakia", Currency = "Koruna", CurrencyCode = "SKK", PhoneCode = "+421")]
      Slovakia = 159,
      [CountryInfo(Code = "SI", Name = "Slovenia", Currency = "Tolar", CurrencyCode = "SIT", PhoneCode = "+386")]
      Slovenia = 160,
      [CountryInfo(Code = "SB", Name = "Solomon Islands", Currency = " Dollar", CurrencyCode = "SBD", PhoneCode = "+677")]
      SolomonIslands = 161,
      [CountryInfo(Code = "SO", Name = "Somalia", Currency = "Schilling", CurrencyCode = "SOS", PhoneCode = "+252")]
      Somalia = 162,
      [CountryInfo(Code = "ZA", Name = "South Africa", Currency = "Rand", CurrencyCode = "ZAR", PhoneCode = "+27")]
      SouthAfrica = 163,
      [CountryInfo(Code = "KR", Name = "Republic Of Korea", Currency = "", CurrencyCode = "", PhoneCode = "+82")]
      SouthKorea = 164,
      [CountryInfo(Code = "ES", Name = "Spain", Currency = "Peseta", CurrencyCode = "ESP", PhoneCode = "+34")]
      Spain = 165,
      [CountryInfo(Code = "LK", Name = "Sri Lanka", Currency = "Rupee", CurrencyCode = "LKR", PhoneCode = "+94")]
      SriLanka = 166,
      [CountryInfo(Code = "SD", Name = "Sudan", Currency = "Dinar", CurrencyCode = "SDD", PhoneCode = "+249")]
      Sudan = 167,
      [CountryInfo(Code = "SR", Name = "Suriname", Currency = "Guilder", CurrencyCode = "SRG", PhoneCode = "+597")]
      Suriname = 168,
      [CountryInfo(Code = "SZ", Name = "Swaziland", Currency = "Lilangeni", CurrencyCode = "SZL", PhoneCode = "+268")]
      Swaziland = 169,
      [CountryInfo(Code = "SE", Name = "Sweden", Currency = "Krona", CurrencyCode = "SEK", PhoneCode = "+46")]
      Sweden = 170,
      [CountryInfo(Code = "CH", Name = "Switzerland", Currency = "Franc", CurrencyCode = "CHF", PhoneCode = "+41")]
      Switzerland = 171,
      [CountryInfo(Code = "SY", Name = "Syrian Arab Republic", Currency = "Pound", CurrencyCode = "SYP", PhoneCode = "+963")]
      SyrianArabRepublic = 172,
      [CountryInfo(Code = "TJ", Name = "Tajikistan", Currency = "", CurrencyCode = "", PhoneCode = "+992")]
      Tajikistan = 173,
      [CountryInfo(Code = "TW", Name = "Taiwan, Province Of China", Currency = "Dollar", CurrencyCode = "TWD", PhoneCode = "+886")]
      Taiwan = 174,
      [CountryInfo(Code = "TZ", Name = "United Republic Of Tanzania", Currency = "Schilling", CurrencyCode = "TZS", PhoneCode = "+255")]
      Tanzania = 175,
      [CountryInfo(Code = "TH", Name = "Thailand", Currency = "Baht", CurrencyCode = "THB", PhoneCode = "+66")]
      Thailand = 176,
      [CountryInfo(Code = "TG", Name = "Togo", Currency = "CFA Franc BCEAO", CurrencyCode = "XOF", PhoneCode = "+228")]
      Togo = 177,
      [CountryInfo(Code = "TK", Name = "Tokelau", Currency = "", CurrencyCode = "", PhoneCode = "+690")]
      Tokelau = 178,
      [CountryInfo(Code = "TO", Name = "Tonga", Currency = "Pa'anga", CurrencyCode = "TOP", PhoneCode = "+676")]
      Tonga = 179,
      [CountryInfo(Code = "TN", Name = "Tunisia", Currency = "Dinar", CurrencyCode = "TND", PhoneCode = "+216")]
      Tunisia = 180,
      [CountryInfo(Code = "TR", Name = "Turkey", Currency = "Lira", CurrencyCode = "TRL", PhoneCode = "+90")]
      Turkey = 181,
      [CountryInfo(Code = "TM", Name = "Turkmenistan", Currency = "", CurrencyCode = "", PhoneCode = "+993")]
      Turkmenistan87 = 182,
      [CountryInfo(Code = "TV", Name = "Tuvalu", Currency = "", CurrencyCode = "", PhoneCode = "+688")]
      Tuvalu = 183,
      [CountryInfo(Code = "UG", Name = "Uganda", Currency = "Schilling", CurrencyCode = "UGS", PhoneCode = "+256")]
      Uganda = 184,
      [CountryInfo(Code = "UA", Name = "Ukraine", Currency = "Hryvnia", CurrencyCode = "UAG", PhoneCode = "+380")]
      Ukraine = 185,
      [CountryInfo(Code = "AE", Name = "United Arab Emirates", Currency = "Dirham", CurrencyCode = "AED", PhoneCode = "+971")]
      UnitedArabEmirates = 186,
      [CountryInfo(Code = "US", Name = "United States", Currency = "Dollar", CurrencyCode = "USD", PhoneCode = "+1")]
      UnitedStates = 187,
      [CountryInfo(Code = "UY", Name = "Uruguay", Currency = "Peso", CurrencyCode = "UYP", PhoneCode = "+598")]
      Uruguay = 188,
      [CountryInfo(Code = "UZ", Name = "Uzbekistan", Currency = "", CurrencyCode = "", PhoneCode = "+998")]
      Uzbekistan = 189,
      [CountryInfo(Code = "VU", Name = "Vanuatu", Currency = "Vatu", CurrencyCode = "VUV", PhoneCode = "+678")]
      Vanuatu = 190,
      [CountryInfo(Code = "VE", Name = "Bolivarian Republic Of Venezuela", Currency = "Bolivar", CurrencyCode = "VEB", PhoneCode = "+58")]
      Venezuela = 191,
      [CountryInfo(Code = "VN", Name = "Viet Nam", Currency = "Dong", CurrencyCode = "VND", PhoneCode = "+84")]
      VietNam = 192,
      [CountryInfo(Code = "WF", Name = "Wallis And Futuna", Currency = "", CurrencyCode = "", PhoneCode = "+681")]
      WallisFutuna = 193,
      [CountryInfo(Code = "YE", Name = "Yemen", Currency = "", CurrencyCode = "", PhoneCode = "+967")]
      Yemen = 194,
      [CountryInfo(Code = "ZM", Name = "Zambia", Currency = "Kwacha", CurrencyCode = "ZMK", PhoneCode = "+260")]
      Zambia = 195,
      [CountryInfo(Code = "ZW", Name = "Zimbabwe", Currency = "Dollar", CurrencyCode = "ZWD", PhoneCode = "+263")]
      Zimbabwe = 196,
    }

    public static string GetCountryName(this Enum value)
    {
      CountryInfoAttribute[] attriburte = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(CountryInfoAttribute), false) as CountryInfoAttribute[];
      return attriburte[0].Name;
    }

    public static string GetCountryCode(this Enum value)
    {
      CountryInfoAttribute[] attriburte = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(CountryInfoAttribute), false) as CountryInfoAttribute[];
      return attriburte[0].Code.ToUpper();
    }

    public static string GetCurrency(this Enum value)
    {
      CountryInfoAttribute[] attriburte = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(CountryInfoAttribute), false) as CountryInfoAttribute[];
      return attriburte[0].Currency;
    }

    public static string GetCurrencyCode(this Enum value)
    {
      CountryInfoAttribute[] attriburte = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(CountryInfoAttribute), false) as CountryInfoAttribute[];
      return attriburte[0].CurrencyCode;
    }

    public static string GetPhoneCode(this Enum value)
    {
      CountryInfoAttribute[] attriburte = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(CountryInfoAttribute), false) as CountryInfoAttribute[];
      return attriburte[0].PhoneCode;
    }

    public static Info GetEnum(string searchField)
    {
      return Info.GetValues(typeof(Info)).Cast<Info>().FirstOrDefault(v => v.GetCountryCode().ToUpper() == searchField.ToUpper() || v.GetCountryName().ToLower() == searchField.ToLower());
    }
  }

  internal class CountryInfoAttribute : Attribute
  {
    public string Name { get; set; }
    public string Code { get; set; }
    public string Currency { get; set; }
    public string CurrencyCode { get; set; }
    public string PhoneCode { get; set; }
  }
}
