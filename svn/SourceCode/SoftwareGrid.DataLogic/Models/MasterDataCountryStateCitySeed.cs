using System.Collections.Generic;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.DataLogic.Seed
{
   
    public sealed class RegionSeed
    {
        public static List<Region> Regions
        {
            get
            {
                List<Region> items = new List<Region>();

                items.Add(new Region { RegionID = 1, Name = "North America" });
                items.Add(new Region { RegionID = 2, Name = "GCC" });
                items.Add(new Region { RegionID = 3, Name = "Europe" });
                items.Add(new Region { RegionID = 4, Name = "Middle East" });
                items.Add(new Region { RegionID = 5, Name = "Asia" });
                items.Add(new Region { RegionID = 6, Name = "South East Asia" });
                items.Add(new Region { RegionID = 7, Name = "Australia" });
                items.Add(new Region { RegionID = 8, Name = "Africa" });
                items.Add(new Region { RegionID = 9, Name = "Central America and the Caribbean" });
                items.Add(new Region { RegionID = 10, Name = "South America" });

                return items;
            }
        }
    }
    public sealed class CountrySeed
    {
        public static List<Country> Countries
        {
            get
            {
                List<Country> items = new List<Country>();

                items.Add(new Country { CountryID=1, Name="United States", CountryTicker="USA"});
                items.Add(new Country { CountryID=2, Name="United Kingdom", CountryTicker="UK"});
                items.Add(new Country { CountryID=3, Name="United Arab Emirates", CountryTicker="UAE"});
                items.Add(new Country { CountryID=4, Name="Swaziland", CountryTicker="SWZ"});
                items.Add(new Country { CountryID=5, Name="India", CountryTicker="IND"});
                items.Add(new Country { CountryID=6, Name="France", CountryTicker="FRA"});
                items.Add(new Country { CountryID=7, Name="Canada", CountryTicker="CAN"});
                items.Add(new Country { CountryID=8, Name="Australia", CountryTicker="AUS"});
                items.Add(new Country { CountryID=9, Name="China", CountryTicker="CHN"});
                items.Add(new Country { CountryID=10, Name="Germany", CountryTicker="GER"});
                items.Add(new Country { CountryID=11, Name="Austria", CountryTicker="AUT"});
                items.Add(new Country { CountryID=12, Name="Azerbaijan", CountryTicker="AZE"});
                items.Add(new Country { CountryID=13, Name="Bahamas", CountryTicker="BHS"});
                items.Add(new Country { CountryID=14, Name="Bahrain", CountryTicker="BHR"});
                items.Add(new Country { CountryID=15, Name="Bangladesh", CountryTicker="BGD"});
                items.Add(new Country { CountryID=16, Name="Barbados", CountryTicker="BRB"});
                items.Add(new Country { CountryID=17, Name="Belarus", CountryTicker="BLR"});
                items.Add(new Country { CountryID=18, Name="Belgium", CountryTicker="BEL"});
                items.Add(new Country { CountryID=19, Name="Belize", CountryTicker="BLZ"});
                items.Add(new Country { CountryID=20, Name="Benin", CountryTicker="BEN"});
                items.Add(new Country { CountryID=21, Name="Bermuda", CountryTicker="BMU"});
                items.Add(new Country { CountryID=22, Name="Bhutan", CountryTicker="BTN"});
                items.Add(new Country { CountryID=23, Name="Bolivia", CountryTicker="BOL"});
                items.Add(new Country { CountryID=24, Name="Bosnia and Herzegovina", CountryTicker="BIH"});
                items.Add(new Country { CountryID=25, Name="Botswana", CountryTicker="BWA"});
                items.Add(new Country { CountryID=26, Name="Bouvet Island", CountryTicker="BVT"});
                items.Add(new Country { CountryID=27, Name="Brazil", CountryTicker="BRA"});
                items.Add(new Country { CountryID=28, Name="British Virgin Islands", CountryTicker="VGB"});
                items.Add(new Country { CountryID=29, Name="Brunei Darussalam", CountryTicker="BRN"});
                items.Add(new Country { CountryID=30, Name="Bulgaria", CountryTicker="BGR"});
                items.Add(new Country { CountryID=31, Name="Burkina Faso", CountryTicker="BFA"});
                items.Add(new Country { CountryID=32, Name="Burundi", CountryTicker="BDI"});
                items.Add(new Country { CountryID=33, Name="Cambodia", CountryTicker="KHM"});
                items.Add(new Country { CountryID=34, Name="Cameroon", CountryTicker="CMR"});
                items.Add(new Country { CountryID=35, Name="Cape Verde", CountryTicker="CPV"});
                items.Add(new Country { CountryID=36, Name="Cayman Islands", CountryTicker="CYM"});
                items.Add(new Country { CountryID=37, Name="Central African Republic", CountryTicker="CAF"});
                items.Add(new Country { CountryID=38, Name="Chad", CountryTicker="TCD"});
                items.Add(new Country { CountryID=39, Name="Chile", CountryTicker="CHL"});
                items.Add(new Country { CountryID=40, Name="Colombia", CountryTicker="COL"});
                items.Add(new Country { CountryID=41, Name="Comoros", CountryTicker="COM"});
                items.Add(new Country { CountryID=42, Name="Congo", CountryTicker="COG"});
                items.Add(new Country { CountryID=43, Name="Cook Islands", CountryTicker="COK"});
                items.Add(new Country { CountryID=44, Name="Costa Rica", CountryTicker="CRI"});
                items.Add(new Country { CountryID=45, Name="Cote d'Ivoire", CountryTicker="CIV"});
                items.Add(new Country { CountryID=46, Name="Croatia", CountryTicker="HRV"});
                items.Add(new Country { CountryID=47, Name="Cuba", CountryTicker="CUB"});
                items.Add(new Country { CountryID=48, Name="Cyprus", CountryTicker="CYP"});
                items.Add(new Country { CountryID=49, Name="Czech Republic", CountryTicker="CZE"});
                items.Add(new Country { CountryID=50, Name="Denmark", CountryTicker="DNK"});
                items.Add(new Country { CountryID=51, Name="Djibouti", CountryTicker="DJI"});
                items.Add(new Country { CountryID=52, Name="Dominica", CountryTicker="DMA"});
                items.Add(new Country { CountryID=53, Name="Dominican Republic", CountryTicker="DOM"});
                items.Add(new Country { CountryID=54, Name="East Timor", CountryTicker="TLS"});
                items.Add(new Country { CountryID=55, Name="Ecuador", CountryTicker="ECU"});
                items.Add(new Country { CountryID=56, Name="Egypt", CountryTicker="EGY"});
                items.Add(new Country { CountryID=57, Name="El Salvador", CountryTicker="SLV"});
                items.Add(new Country { CountryID=58, Name="Equatorial Guinea", CountryTicker="GNQ"});
                items.Add(new Country { CountryID=59, Name="Eritrea", CountryTicker="ERI"});
                items.Add(new Country { CountryID=60, Name="Estonia", CountryTicker="EST"});
                items.Add(new Country { CountryID=61, Name="Ethiopia", CountryTicker="ETH"});
                items.Add(new Country { CountryID=62, Name="Europe	Kosovo", CountryTicker="EKV"});
                items.Add(new Country { CountryID=63, Name="Faeroe Islands", CountryTicker="FRO"});
                items.Add(new Country { CountryID=64, Name="Fiji", CountryTicker="FJI"});
                items.Add(new Country { CountryID=65, Name="Finland", CountryTicker="FIN"});
                items.Add(new Country { CountryID=66, Name="France Metropolitan", CountryTicker="FXX"});
                items.Add(new Country { CountryID=67, Name="French Guiana", CountryTicker="GUF"});
                items.Add(new Country { CountryID=68, Name="French Polynesia", CountryTicker="PYF"});
                items.Add(new Country { CountryID=69, Name="Gabon", CountryTicker="GAB"});
                items.Add(new Country { CountryID=70, Name="Gambia", CountryTicker="GMB"});
                items.Add(new Country { CountryID=71, Name="Haiti", CountryTicker="HTI"});
                items.Add(new Country { CountryID=72, Name="Honduras", CountryTicker="HND"});
                items.Add(new Country { CountryID=73, Name="Hong Kong", CountryTicker="HKG"});
                items.Add(new Country { CountryID=74, Name="Hungary", CountryTicker="HUN"});
                items.Add(new Country { CountryID=75, Name="Iceland", CountryTicker="ISL"});
                items.Add(new Country { CountryID=76, Name="Indonesia", CountryTicker="IDN"});
                items.Add(new Country { CountryID=77, Name="Iran", CountryTicker="IRN"});
                items.Add(new Country { CountryID=78, Name="Iraq", CountryTicker="IRQ"});
                items.Add(new Country { CountryID=79, Name="Ireland", CountryTicker="IRL"});
                items.Add(new Country { CountryID=80, Name="Israel", CountryTicker="ISR"});
                items.Add(new Country { CountryID=81, Name="Italy", CountryTicker="ITA"});
                items.Add(new Country { CountryID=82, Name="Jamaica", CountryTicker="JAM"});
                items.Add(new Country { CountryID=83, Name="Japan", CountryTicker="JPN"});
                items.Add(new Country { CountryID=84, Name="Jordan", CountryTicker="JOR"});
                items.Add(new Country { CountryID=85, Name="Kazakhstan", CountryTicker="KAZ"});
                items.Add(new Country { CountryID=86, Name="Kenya", CountryTicker="KEN"});
                items.Add(new Country { CountryID=87, Name="Kiribati", CountryTicker="KIR"});
                items.Add(new Country { CountryID=88, Name="Kuwait", CountryTicker="KWT"});
                items.Add(new Country { CountryID=89, Name="Kyrgyzstan", CountryTicker="KGZ"});
                items.Add(new Country { CountryID=90, Name="Laos", CountryTicker="LAO"});
                items.Add(new Country { CountryID=91, Name="Latvia", CountryTicker=""});
                items.Add(new Country { CountryID=92, Name="Lebanon", CountryTicker="LBN"});
                items.Add(new Country { CountryID=93, Name="Lesotho", CountryTicker="LSO"});
                items.Add(new Country { CountryID=94, Name="Liberia", CountryTicker="LBR"});
                items.Add(new Country { CountryID=95, Name="Libya", CountryTicker="LBY"});
                items.Add(new Country { CountryID=96, Name="Liechtenstein", CountryTicker="LIE"});
                items.Add(new Country { CountryID=97, Name="Lithuania", CountryTicker="LTU"});
                items.Add(new Country { CountryID=98, Name="Luxembourg", CountryTicker="LUX"});
                items.Add(new Country { CountryID=99, Name="Macau", CountryTicker="MAC"});
                items.Add(new Country { CountryID=100, Name="Macedonia", CountryTicker="MKD"});
                items.Add(new Country { CountryID=101, Name="Madagascar", CountryTicker="MDG"});
                items.Add(new Country { CountryID=102, Name="Malawi", CountryTicker="MWI"});
                items.Add(new Country { CountryID=103, Name="Malaysia", CountryTicker="MYS"});
                items.Add(new Country { CountryID=104, Name="Maldives", CountryTicker="MDV"});
                items.Add(new Country { CountryID=105, Name="Mali", CountryTicker="MLI"});
                items.Add(new Country { CountryID=106, Name="Malta", CountryTicker="MLT"});
                items.Add(new Country { CountryID=107, Name="Marshall Islands", CountryTicker="MHL"});
                items.Add(new Country { CountryID=108, Name="Martinique", CountryTicker="MTQ"});
                items.Add(new Country { CountryID=109, Name="Mauritania", CountryTicker="MRT"});
                items.Add(new Country { CountryID=110, Name="Mauritius", CountryTicker="MUS"});
                items.Add(new Country { CountryID=111, Name="Mayotte", CountryTicker="MYT"});
                items.Add(new Country { CountryID=112, Name="Mexico", CountryTicker="MEX"});
                items.Add(new Country { CountryID=113, Name="Micronesia", CountryTicker="FSM"});
                items.Add(new Country { CountryID=114, Name="Moldova", CountryTicker="MDA"});
                items.Add(new Country { CountryID=115, Name="Monaco", CountryTicker="MCO"});
                items.Add(new Country { CountryID=116, Name="Mongolia", CountryTicker="MNG"});
                items.Add(new Country { CountryID=117, Name="Montenegro", CountryTicker="MNE"});
                items.Add(new Country { CountryID=118, Name="Montserrat", CountryTicker="MSR"});
                items.Add(new Country { CountryID=119, Name="Morocco", CountryTicker="MAR"});
                items.Add(new Country { CountryID=120, Name="Mozambique", CountryTicker="MOZ"});
                items.Add(new Country { CountryID=121, Name="Myanmar", CountryTicker="MMR"});
                items.Add(new Country { CountryID=122, Name="Namibia", CountryTicker="NAM"});
                items.Add(new Country { CountryID=123, Name="Nauru", CountryTicker="NRU"});
                items.Add(new Country { CountryID=124, Name="Nepal", CountryTicker="NPL"});
                items.Add(new Country { CountryID=125, Name="Netherlands", CountryTicker="NLD"});
                items.Add(new Country { CountryID=126, Name="Netherlands Antilles", CountryTicker="ANT"});
                items.Add(new Country { CountryID=127, Name="New Caledonia", CountryTicker="NCL"});
                items.Add(new Country { CountryID=128, Name="New Zealand", CountryTicker="NZL"});
                items.Add(new Country { CountryID=129, Name="Nicaragua", CountryTicker="NIC"});
                items.Add(new Country { CountryID=130, Name="Niger", CountryTicker="NER"});
                items.Add(new Country { CountryID=131, Name="Nigeria", CountryTicker="NGA"});
                items.Add(new Country { CountryID=132, Name="Niue", CountryTicker="NIU"});
                items.Add(new Country { CountryID=133, Name="Norfolk Island", CountryTicker="NFK"});
                items.Add(new Country { CountryID=134, Name="North Korea", CountryTicker="PRK"});
                items.Add(new Country { CountryID=135, Name="Northern Mariana Islands", CountryTicker="MNP"});
                items.Add(new Country { CountryID=136, Name="Portugal", CountryTicker="PRT"});
                items.Add(new Country { CountryID=137, Name="Puerto Rico", CountryTicker="PRI"});
                items.Add(new Country { CountryID=138, Name="Qatar", CountryTicker="QAT"});
                items.Add(new Country { CountryID=139, Name="Republic of Georgia", CountryTicker="GEO"});
                items.Add(new Country { CountryID=140, Name="Reunion", CountryTicker="REU"});
                items.Add(new Country { CountryID=141, Name="Romania", CountryTicker="ROU"});
                items.Add(new Country { CountryID=142, Name="Russia", CountryTicker="RUS"});
                items.Add(new Country { CountryID=143, Name="Rwanda", CountryTicker="RWA"});
                items.Add(new Country { CountryID=144, Name="Samoa", CountryTicker="WSM"});
                items.Add(new Country { CountryID=145, Name="San Marino", CountryTicker="SMR"});
                items.Add(new Country { CountryID=146, Name="Saudi Arabia", CountryTicker="KSA"});
                items.Add(new Country { CountryID=147, Name="Senegal", CountryTicker="SEN"});
                items.Add(new Country { CountryID=148, Name="Serbia", CountryTicker="SRB"});
                items.Add(new Country { CountryID=149, Name="Seychelles", CountryTicker="SYC"});
                items.Add(new Country { CountryID=150, Name="Sierra Leone", CountryTicker="SLE"});
                items.Add(new Country { CountryID=151, Name="Singapore", CountryTicker="SGP"});
                items.Add(new Country { CountryID=152, Name="Slovakia", CountryTicker="SVK"});
                items.Add(new Country { CountryID=153, Name="Slovenia", CountryTicker="SVN"});
                items.Add(new Country { CountryID=154, Name="Solomon Islands", CountryTicker="SLB"});
                items.Add(new Country { CountryID=155, Name="Somalia", CountryTicker="SOM"});
                items.Add(new Country { CountryID=156, Name="South Africa", CountryTicker="ZAF"});
                items.Add(new Country { CountryID=157, Name="South Georgia", CountryTicker="SGS"});
                items.Add(new Country { CountryID=158, Name="South Korea", CountryTicker="KOR"});
                items.Add(new Country { CountryID=159, Name="Spain", CountryTicker="ESP"});
                items.Add(new Country { CountryID=160, Name="Sri Lanka", CountryTicker="LKA"});
                items.Add(new Country { CountryID=161, Name="St. Helena", CountryTicker="SHN"});
                items.Add(new Country { CountryID=162, Name="St. Kitts and Nevis", CountryTicker="KNA"});
                items.Add(new Country { CountryID=163, Name="St. Lucia", CountryTicker="LCA"});
                items.Add(new Country { CountryID=164, Name="Sudan", CountryTicker="SDN"});
                items.Add(new Country { CountryID=165, Name="Suriname", CountryTicker="SUR"});
                items.Add(new Country { CountryID=166, Name="Sweden", CountryTicker="SWE"});
                items.Add(new Country { CountryID=167, Name="Switzerland", CountryTicker="CHE"});
                items.Add(new Country { CountryID=168, Name="Syria", CountryTicker="SYR"});
                items.Add(new Country { CountryID=169, Name="Taiwan", CountryTicker="TWN"});
                items.Add(new Country { CountryID=170, Name="Tajikistan", CountryTicker="TJK"});
                items.Add(new Country { CountryID=171, Name="Tanzania", CountryTicker="TZA"});
                items.Add(new Country { CountryID=172, Name="Thailand", CountryTicker="THA"});
                items.Add(new Country { CountryID=173, Name="Togo", CountryTicker="TGO"});
                items.Add(new Country { CountryID=174, Name="Tokelau", CountryTicker="TKL"});
                items.Add(new Country { CountryID=175, Name="Tonga", CountryTicker="TON"});
                items.Add(new Country { CountryID=176, Name="Trinidad and Tobago", CountryTicker="TTO"});
                items.Add(new Country { CountryID=177, Name="Tunisia", CountryTicker="TUN"});
                items.Add(new Country { CountryID=178, Name="Turkey", CountryTicker="TUR"});
                items.Add(new Country { CountryID=179, Name="Turkmenistan", CountryTicker="TKM"});
                items.Add(new Country { CountryID=180, Name="Tuvalu", CountryTicker="TUV"});
                items.Add(new Country { CountryID=181, Name="U.S. Virgin Islands", CountryTicker="VIR"});
                items.Add(new Country { CountryID=182, Name="Uganda", CountryTicker="UGA"});
                items.Add(new Country { CountryID=183, Name="Ukraine", CountryTicker="UKR"});
                items.Add(new Country { CountryID=184, Name="Uruguay", CountryTicker="URY"});
                items.Add(new Country { CountryID=185, Name="Uzbekistan", CountryTicker="UZB"});
                items.Add(new Country { CountryID=186, Name="Vanuatu", CountryTicker="VUT"});
                items.Add(new Country { CountryID=187, Name="Vatican City", CountryTicker="VAT"});
                items.Add(new Country { CountryID=188, Name="Venezuela", CountryTicker="VEN"});
                items.Add(new Country { CountryID=189, Name="Vietnam", CountryTicker="VNM"});
                items.Add(new Country { CountryID=190, Name="Western Sahara", CountryTicker="ESH"});
                items.Add(new Country { CountryID=191, Name="Yemen", CountryTicker="YEM"});
                items.Add(new Country { CountryID=192, Name="Yugoslavia", CountryTicker="YUG"});
                items.Add(new Country { CountryID=193, Name="Zambia", CountryTicker="ZMB"});
                items.Add(new Country { CountryID=194, Name="Zimbabwe", CountryTicker="ZWE"});
                
                return items;
            }
        }
    }
    public sealed class StateSeed
    {
        public static List<State> States
        {
            get
            {
                List<State> items = new List<State>();

                items.Add(new State { StateID = 1, Name = "Alaska", StateTicker="AK", CountryID = 1 });
                items.Add(new State { StateID = 2, Name = "Alabama", StateTicker="AL", CountryID = 1 });
                items.Add(new State { StateID = 3, Name = "Arkansas", StateTicker="AR", CountryID = 1 });
                items.Add(new State { StateID = 4, Name = "Arizona", StateTicker="AZ", CountryID = 1 });
                items.Add(new State { StateID = 5, Name = "California", StateTicker="CA", CountryID = 1 });
                items.Add(new State { StateID = 6, Name = "Colorado", StateTicker="CO", CountryID = 1 });
                items.Add(new State { StateID = 7, Name = "Connecticut", StateTicker="CT", CountryID = 1 });
                items.Add(new State { StateID = 8, Name = "District of Columbia", StateTicker="DC", CountryID = 1 });
                items.Add(new State { StateID = 9, Name = "Delaware", StateTicker="DE", CountryID = 1 });
                items.Add(new State { StateID = 10, Name = "Florida", StateTicker="FL", CountryID = 1 });
                items.Add(new State { StateID = 11, Name = "Georgia", StateTicker="GA", CountryID = 1 });
                items.Add(new State { StateID = 12, Name = "Hawaii", StateTicker="HI", CountryID = 1 });
                items.Add(new State { StateID = 13, Name = "Iowa", StateTicker="IA", CountryID = 1 });
                items.Add(new State { StateID = 14, Name = "Idaho", StateTicker="ID", CountryID = 1 });
                items.Add(new State { StateID = 15, Name = "Illinois", StateTicker="IL", CountryID = 1 });
                items.Add(new State { StateID = 16, Name = "Indiana", StateTicker="IN", CountryID = 1 });
                items.Add(new State { StateID = 17, Name = "Kansas", StateTicker="KS", CountryID = 1 });
                items.Add(new State { StateID = 18, Name = "Kentucky", StateTicker="KY", CountryID = 1 });
                items.Add(new State { StateID = 19, Name = "Louisiana", StateTicker="LA", CountryID = 1 });
                items.Add(new State { StateID = 20, Name = "Massachusetts", StateTicker="MA", CountryID = 1 });
                items.Add(new State { StateID = 21, Name = "Maryland", StateTicker="MD", CountryID = 1 });
                items.Add(new State { StateID = 22, Name = "Maine", StateTicker="ME", CountryID = 1 });
                items.Add(new State { StateID = 23, Name = "Michigan", StateTicker="MI", CountryID = 1 });
                items.Add(new State { StateID = 24, Name = "Minnesota", StateTicker="MN", CountryID = 1 });
                items.Add(new State { StateID = 25, Name = "Missouri", StateTicker="MO", CountryID = 1 });
                items.Add(new State { StateID = 26, Name = "Mississippi", StateTicker="MS", CountryID = 1 });
                items.Add(new State { StateID = 27, Name = "Montana", StateTicker="MT", CountryID = 1 });
                items.Add(new State { StateID = 28, Name = "North Carolina", StateTicker="NC", CountryID = 1 });
                items.Add(new State { StateID = 29, Name = "North Dakota", StateTicker="ND", CountryID = 1 });
                items.Add(new State { StateID = 30, Name = "Nebraska", StateTicker="NE", CountryID = 1 });
                items.Add(new State { StateID = 31, Name = "New Hampshire", StateTicker="NH", CountryID = 1 });
                items.Add(new State { StateID = 32, Name = "New Jersey", StateTicker="NJ", CountryID = 1 });
                items.Add(new State { StateID = 33, Name = "New Mexico", StateTicker="NM", CountryID = 1 });
                items.Add(new State { StateID = 34, Name = "Nevada", StateTicker="NV", CountryID = 1 });
                items.Add(new State { StateID = 35, Name = "New York", StateTicker="NY", CountryID = 1 });
                items.Add(new State { StateID = 36, Name = "Ohio", StateTicker="OH", CountryID = 1 });
                items.Add(new State { StateID = 37, Name = "Oklahoma", StateTicker="OK", CountryID = 1 });
                items.Add(new State { StateID = 38, Name = "Oregon", StateTicker="OR", CountryID = 1 });
                items.Add(new State { StateID = 39, Name = "Pennsylvania", StateTicker="PA", CountryID = 1 });
                items.Add(new State { StateID = 40, Name = "Rhode Island", StateTicker="RI", CountryID = 1 });
                items.Add(new State { StateID = 41, Name = "South Carolina", StateTicker="SC", CountryID = 1 });
                items.Add(new State { StateID = 42, Name = "South Dakota", StateTicker="SD", CountryID = 1 });
                items.Add(new State { StateID = 43, Name = "Tennessee", StateTicker="TN", CountryID = 1 });
                items.Add(new State { StateID = 44, Name = "Texas", StateTicker="TX", CountryID = 1 });
                items.Add(new State { StateID = 45, Name = "Utah", StateTicker="UT", CountryID = 1 });
                items.Add(new State { StateID = 46, Name = "Vermont", StateTicker="VT", CountryID = 1 });
                items.Add(new State { StateID = 47, Name = "Virginia", StateTicker="VA", CountryID = 1 });
                items.Add(new State { StateID = 48, Name = "Washington", StateTicker="WA", CountryID = 1 });
                items.Add(new State { StateID = 49, Name = "Wisconsin", StateTicker="WI", CountryID = 1 });
                items.Add(new State { StateID = 50, Name = "West Virginia", StateTicker="WV", CountryID = 1 });
                items.Add(new State { StateID = 51, Name = "Wyoming", StateTicker="WY", CountryID = 1 });

                items.Add(new State { StateID = 52, Name = "Abu Dhabi", StateTicker = "", CountryID = 3 });
                items.Add(new State { StateID = 53, Name = "Dubai", StateTicker = "", CountryID = 3 });
                items.Add(new State { StateID = 54, Name = "Ajman", StateTicker = "", CountryID = 3 });
                items.Add(new State { StateID = 55, Name = "Sharjah", StateTicker = "", CountryID = 3 });
                items.Add(new State { StateID = 56, Name = "Um Al Quwain", StateTicker = "", CountryID = 3 });
                items.Add(new State { StateID = 57, Name = "Fujairah", StateTicker = "", CountryID = 3 });
                items.Add(new State { StateID = 58, Name = "Ras al Khaimah", StateTicker = "", CountryID = 3 });

                items.Add(new State { StateID = 59, Name = "Andra pradesh", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 60, Name = "Arunachal Pradesh", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 61, Name = "Assam", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 62, Name = "Bihar", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 63, Name = "Chhattisgarh", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 64, Name = "Goa", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 65, Name = "Gujarat", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 66, Name = "Haryana", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 67, Name = "Himachal Pradesh", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 68, Name = "Jammu and Kashmir", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 69, Name = "Jharkhand", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 70, Name = "Karnataka", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 71, Name = "Kerala", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 72, Name = "Madhya Pradesh", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 73, Name = "Maharashtra", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 74, Name = "Manipur", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 75, Name = "Meghalaya", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 76, Name = "Mizoram", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 77, Name = "Nagaland", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 78, Name = "Orissa", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 79, Name = "Punjab", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 80, Name = "Rajasthan", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 81, Name = "Sikkim", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 82, Name = "Tamil Nadu", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 83, Name = "Tripura", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 84, Name = "Uttar Pradesh", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 85, Name = "Uttarakhand", StateTicker = "", CountryID = 5 });
                items.Add(new State { StateID = 86, Name = "West Bengal", StateTicker = "", CountryID = 5 });

                items.Add(new State { StateID = 87, Name = "British Columbia", StateTicker = "", CountryID = 7 });
                items.Add(new State { StateID = 88, Name = "Manitoba", StateTicker = "", CountryID = 7 });
                items.Add(new State { StateID = 89, Name = "New Brunswick", StateTicker = "", CountryID = 7 });
                items.Add(new State { StateID = 90, Name = "New Foundland", StateTicker = "", CountryID = 7 });
                items.Add(new State { StateID = 91, Name = "Northwest Territories", StateTicker = "", CountryID = 7 });
                items.Add(new State { StateID = 92, Name = "Nova Scotia", StateTicker = "", CountryID = 7 });
                items.Add(new State { StateID = 93, Name = "Ontario", StateTicker = "", CountryID = 7 });
                items.Add(new State { StateID = 94, Name = "Prince Edward Island", StateTicker = "", CountryID = 7 });
                items.Add(new State { StateID = 95, Name = "Quebec", StateTicker = "", CountryID = 7 });
                items.Add(new State { StateID = 96, Name = "Saskatchewan", StateTicker = "", CountryID = 7 });
                items.Add(new State { StateID = 97, Name = "Yukon Territories", StateTicker = "", CountryID = 7 });

                items.Add(new State { StateID = 98, Name = "Baden-Württemberg", StateTicker = "", CountryID = 10 });
                items.Add(new State { StateID = 99, Name = "Bavaria (Bayern)", StateTicker = "", CountryID = 10 });
                items.Add(new State { StateID = 100, Name = "Berlin", StateTicker = "", CountryID = 10 });
                items.Add(new State { StateID = 101, Name = "Brandenburg", StateTicker = "", CountryID = 10 });
                items.Add(new State { StateID = 102, Name = "Bremen", StateTicker = "", CountryID = 10 });
                items.Add(new State { StateID = 103, Name = "Hamburg", StateTicker = "", CountryID = 10 });
                items.Add(new State { StateID = 104, Name = "Hesse (Hessen)", StateTicker = "", CountryID = 10 });
                items.Add(new State { StateID = 105, Name = "Mecklenburg-Vorpommern", StateTicker = "", CountryID = 10 });
                items.Add(new State { StateID = 106, Name = "Lower Saxony (Niedersachsen)", StateTicker = "", CountryID = 10 });
                items.Add(new State { StateID = 107, Name = "North Rhine- Westphalia (Nordrhein-Westfalen)", StateTicker = "", CountryID = 10 });
                items.Add(new State { StateID = 108, Name = "Rhineland-Palatinate (Rheinland-Pfalz)", StateTicker = "", CountryID = 10 });
                items.Add(new State { StateID = 109, Name = "Saarland", StateTicker = "", CountryID = 10 });
                items.Add(new State { StateID = 110, Name = "Saxony (Sachsen)", StateTicker = "", CountryID = 10 });
                items.Add(new State { StateID = 111, Name = "Saxony-Anhalt (Sachsen-Anhalt)", StateTicker = "", CountryID = 10 });
                items.Add(new State { StateID = 112, Name = "Schleswig-Holstein", StateTicker = "", CountryID = 10 });
                items.Add(new State { StateID = 113, Name = "Thuringia (Thüringen)", StateTicker = "", CountryID = 10 });
                


                return items;
            }
        }
    }
    public sealed class CitySeed
    {
        public static List<City> Cities
        {
            get
            {
                List<City> items = new List<City>();

                items.Add(new City { CityID = 1, Name = "Milwaukee", StateID = 49, CountryID = 1 });
                items.Add(new City { CityID = 2, Name = "Madison", StateID = 49, CountryID = 1 });
                items.Add(new City { CityID = 3, Name = "Green Bay", StateID = 49, CountryID = 1 });

                items.Add(new City { CityID = 4, Name = "Seattle", StateID = 48, CountryID = 1 });
                items.Add(new City { CityID = 5, Name = "Tacoma", StateID = 48, CountryID = 1 });
                items.Add(new City { CityID = 6, Name = "Vancouver", StateID = 48, CountryID = 1 });
                items.Add(new City { CityID = 7, Name = "Spokane", StateID = 48, CountryID = 1 });
                items.Add(new City { CityID = 8, Name = "Everett", StateID = 48, CountryID = 1 });
                items.Add(new City { CityID = 9, Name = "Bellevue", StateID = 48, CountryID = 1 });

                items.Add(new City { CityID = 10, Name = "Norfolk", StateID = 47, CountryID = 1 });
                items.Add(new City { CityID = 11, Name = "Newport News", StateID = 47, CountryID = 1 });
                items.Add(new City { CityID = 12, Name = "Richmond", StateID = 47, CountryID = 1 });
                items.Add(new City { CityID = 13, Name = "Virginia Beach", StateID = 47, CountryID = 1 });
                items.Add(new City { CityID = 14, Name = "Hampton", StateID = 47, CountryID = 1 });
                items.Add(new City { CityID = 15, Name = "Chesapeake", StateID = 47, CountryID = 1 });
                items.Add(new City { CityID = 16, Name = "Arlington", StateID = 47, CountryID = 1 });
                items.Add(new City { CityID = 17, Name = "Alexandria", StateID = 47, CountryID = 1 });

                items.Add(new City { CityID = 18, Name = "Provo", StateID = 45, CountryID = 1 });
                items.Add(new City { CityID = 19, Name = "West Valley City", StateID = 45, CountryID = 1 });
                items.Add(new City { CityID = 20, Name = "West Jordan", StateID = 45, CountryID = 1 });
                items.Add(new City { CityID = 21, Name = "Salt Lake City", StateID = 45, CountryID = 1 });

                items.Add(new City { CityID = 22, Name = "McAllen", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 23, Name = "McKinney", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 24, Name = "Lubbock", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 25, Name = "Midland", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 26, Name = "Mesquite", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 27, Name = "Plano", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 28, Name = "Pasadena", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 29, Name = "Wichita Falls", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 30, Name = "Waco", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 31, Name = "San Antonio", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 32, Name = "Garland", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 33, Name = "Frisco", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 34, Name = "Fort Worth", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 35, Name = "Grand Prairie", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 36, Name = "El Paso", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 37, Name = "Killeen", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 38, Name = "Laredo", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 39, Name = "Houston", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 40, Name = "Irving", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 41, Name = "Carrollton", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 42, Name = "Denton", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 43, Name = "Corpus Christi", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 44, Name = "Dallas", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 45, Name = "Austin", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 46, Name = "Beaumont", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 47, Name = "Brownsville", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 48, Name = "Arlington", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 49, Name = "Amarillo", StateID = 44, CountryID = 1 });
                items.Add(new City { CityID = 50, Name = "Abilene", StateID = 44, CountryID = 1 });

                items.Add(new City { CityID = 51, Name = "Memphis", StateID = 43, CountryID = 1 });
                items.Add(new City { CityID = 52, Name = "Nashville ", StateID = 43, CountryID = 1 });
                items.Add(new City { CityID = 53, Name = "Murfreesboro", StateID = 43, CountryID = 1 });
                items.Add(new City { CityID = 54, Name = "Knoxville", StateID = 43, CountryID = 1 });
                items.Add(new City { CityID = 55, Name = "Chattanooga", StateID = 43, CountryID = 1 });
                items.Add(new City { CityID = 56, Name = "Clarksville", StateID = 43, CountryID = 1 });

                items.Add(new City { CityID = 57, Name = "Sioux Falls", StateID = 42, CountryID = 1 });

                items.Add(new City { CityID = 58, Name = "Charleston", StateID = 41, CountryID = 1 });
                items.Add(new City { CityID = 59, Name = "Columbia", StateID = 41, CountryID = 1 });

                items.Add(new City { CityID = 60, Name = "Providence", StateID = 40, CountryID = 1 });

                items.Add(new City { CityID = 61, Name = "Philadelphia", StateID = 39, CountryID = 1 });
                items.Add(new City { CityID = 62, Name = "Pittsburgh", StateID = 39, CountryID = 1 });
                items.Add(new City { CityID = 63, Name = "Erie", StateID = 39, CountryID = 1 });
                items.Add(new City { CityID = 64, Name = "Allentown", StateID = 39, CountryID = 1 });

                items.Add(new City { CityID = 65, Name = "Portland", StateID = 38, CountryID = 1 });
                items.Add(new City { CityID = 66, Name = "Salem", StateID = 38, CountryID = 1 });
                items.Add(new City { CityID = 67, Name = "Eugene", StateID = 38, CountryID = 1 });
                items.Add(new City { CityID = 68, Name = "Gresham", StateID = 38, CountryID = 1 });

                items.Add(new City { CityID = 69, Name = "Norman", StateID = 37, CountryID = 1 });
                items.Add(new City { CityID = 70, Name = "Oklahoma City", StateID = 37, CountryID = 1 });
                items.Add(new City { CityID = 71, Name = "Tulsa", StateID = 37, CountryID = 1 });

                items.Add(new City { CityID = 72, Name = "Toledo", StateID = 36, CountryID = 1 });
                items.Add(new City { CityID = 73, Name = "Cleveland", StateID = 36, CountryID = 1 });
                items.Add(new City { CityID = 74, Name = "Cincinnati", StateID = 36, CountryID = 1 });
                items.Add(new City { CityID = 75, Name = "Dayton", StateID = 36, CountryID = 1 });
                items.Add(new City { CityID = 76, Name = "Columbus", StateID = 36, CountryID = 1 });
                items.Add(new City { CityID = 77, Name = "Akron", StateID = 36, CountryID = 1 });

                items.Add(new City { CityID = 78, Name = "Fargo", StateID = 29, CountryID = 1 });

                items.Add(new City { CityID = 79, Name = "Raleigh", StateID = 28, CountryID = 1 });
                items.Add(new City { CityID = 80, Name = "Winston-Salem", StateID = 28, CountryID = 1 });
                items.Add(new City { CityID = 81, Name = "Wilmington", StateID = 28, CountryID = 1 });
                items.Add(new City { CityID = 82, Name = "Durham", StateID = 28, CountryID = 1 });
                items.Add(new City { CityID = 83, Name = "Fayetteville", StateID = 28, CountryID = 1 });
                items.Add(new City { CityID = 84, Name = "Greensboro", StateID = 28, CountryID = 1 });
                items.Add(new City { CityID = 85, Name = "High Point", StateID = 28, CountryID = 1 });
                items.Add(new City { CityID = 86, Name = "Cary", StateID = 28, CountryID = 1 });
                items.Add(new City { CityID = 87, Name = "Charlotte", StateID = 28, CountryID = 1 });

                items.Add(new City { CityID = 88, Name = "New York", StateID = 35, CountryID = 1 });
                items.Add(new City { CityID = 89, Name = "Syracuse", StateID = 35, CountryID = 1 });
                items.Add(new City { CityID = 90, Name = "Yonkers", StateID = 35, CountryID = 1 });
                items.Add(new City { CityID = 91, Name = "Rochester", StateID = 35, CountryID = 1 });
                items.Add(new City { CityID = 92, Name = "Buffalo", StateID = 35, CountryID = 1 });

                items.Add(new City { CityID = 93, Name = "Albuquerque", StateID = 33, CountryID = 1 });

                items.Add(new City { CityID = 94, Name = "Newark", StateID = 32, CountryID = 1 });
                items.Add(new City { CityID = 95, Name = "Paterson", StateID = 32, CountryID = 1 });
                items.Add(new City { CityID = 96, Name = "Elizabeth", StateID = 32, CountryID = 1 });
                items.Add(new City { CityID = 97, Name = "Jersey City", StateID = 32, CountryID = 1 });

                items.Add(new City { CityID = 98, Name = "Manchester", StateID = 31, CountryID = 1 });

                items.Add(new City { CityID = 99, Name = "North Las Vegas", StateID = 34, CountryID = 1 });
                items.Add(new City { CityID = 100, Name = "Reno", StateID = 34, CountryID = 1 });
                items.Add(new City { CityID = 101, Name = "Las Vegas", StateID = 34, CountryID = 1 });
                items.Add(new City { CityID = 102, Name = "Henderson", StateID = 34, CountryID = 1 });

                items.Add(new City { CityID = 103, Name = "Omaha", StateID = 30, CountryID = 1 });
                items.Add(new City { CityID = 104, Name = "Lincoln", StateID = 30, CountryID = 1 });

                items.Add(new City { CityID = 105, Name = "Billings", StateID = 27, CountryID = 1 });

                items.Add(new City { CityID = 106, Name = "Springfield", StateID = 25, CountryID = 1 });
                items.Add(new City { CityID = 107, Name = "Saint Louis", StateID = 25, CountryID = 1 });
                items.Add(new City { CityID = 108, Name = "Kansas City", StateID = 25, CountryID = 1 });
                items.Add(new City { CityID = 109, Name = "Independence", StateID = 25, CountryID = 1 });
                items.Add(new City { CityID = 110, Name = "Columbia", StateID = 25, CountryID = 1 });

                items.Add(new City { CityID = 111, Name = "Jackson", StateID = 26, CountryID = 1 });

                items.Add(new City { CityID = 112, Name = "Minneapolis", StateID = 24, CountryID = 1 });
                items.Add(new City { CityID = 113, Name = "Rochester", StateID = 24, CountryID = 1 });
                items.Add(new City { CityID = 114, Name = "Saint Paul", StateID = 24, CountryID = 1 });

                items.Add(new City { CityID = 115, Name = "Warren", StateID = 23, CountryID = 1 });
                items.Add(new City { CityID = 116, Name = "Sterling Heights", StateID = 23, CountryID = 1 });
                items.Add(new City { CityID = 117, Name = "Flint", StateID = 23, CountryID = 1 });
                items.Add(new City { CityID = 118, Name = "Grand Rapids", StateID = 23, CountryID = 1 });
                items.Add(new City { CityID = 119, Name = "Lansing", StateID = 23, CountryID = 1 });
                items.Add(new City { CityID = 120, Name = "Detroit", StateID = 23, CountryID = 1 });
                items.Add(new City { CityID = 121, Name = "Ann Arbor", StateID = 23, CountryID = 1 });

                items.Add(new City { CityID = 122, Name = "Lowell", StateID = 20, CountryID = 1 });
                items.Add(new City { CityID = 123, Name = "Worcester", StateID = 20, CountryID = 1 });
                items.Add(new City { CityID = 124, Name = "Springfield", StateID = 20, CountryID = 1 });
                items.Add(new City { CityID = 125, Name = "Cambridge", StateID = 20, CountryID = 1 });
                items.Add(new City { CityID = 126, Name = "Boston", StateID = 20, CountryID = 1 });

                items.Add(new City { CityID = 127, Name = "Baltimore", StateID = 21, CountryID = 1 });

                items.Add(new City { CityID = 128, Name = "New Orleans", StateID = 19, CountryID = 1 });
                items.Add(new City { CityID = 129, Name = "Shreveport", StateID = 19, CountryID = 1 });
                items.Add(new City { CityID = 130, Name = "Lafayette", StateID = 19, CountryID = 1 });
                items.Add(new City { CityID = 131, Name = "Baton Rouge", StateID = 19, CountryID = 1 });


                items.Add(new City { CityID = 132, Name = "Louisville", StateID = 18, CountryID = 1 });
                items.Add(new City { CityID = 133, Name = "Lexington", StateID = 18, CountryID = 1 });

                items.Add(new City { CityID = 134, Name = "Overland Park", StateID = 17, CountryID = 1 });
                items.Add(new City { CityID = 135, Name = "Olathe", StateID = 17, CountryID = 1 });
                items.Add(new City { CityID = 136, Name = "Topeka", StateID = 17, CountryID = 1 });
                items.Add(new City { CityID = 137, Name = "Wichita", StateID = 17, CountryID = 1 });
                items.Add(new City { CityID = 138, Name = "Kansas City", StateID = 17, CountryID = 1 });

                items.Add(new City { CityID = 139, Name = "Cedar Rapids", StateID = 13, CountryID = 1 });
                items.Add(new City { CityID = 140, Name = "Des Moines", StateID = 13, CountryID = 1 });

                items.Add(new City { CityID = 141, Name = "South Bend", StateID = 16, CountryID = 1 });
                items.Add(new City { CityID = 142, Name = "Evansville", StateID = 16, CountryID = 1 });
                items.Add(new City { CityID = 143, Name = "Fort Wayne", StateID = 16, CountryID = 1 });
                items.Add(new City { CityID = 144, Name = "Indianapolis", StateID = 16, CountryID = 1 });

                items.Add(new City { CityID = 145, Name = "Naperville", StateID = 15, CountryID = 1 });
                items.Add(new City { CityID = 146, Name = "Peoria", StateID = 15, CountryID = 1 });
                items.Add(new City { CityID = 147, Name = "Springfield", StateID = 15, CountryID = 1 });
                items.Add(new City { CityID = 148, Name = "Rockford", StateID = 15, CountryID = 1 });
                items.Add(new City { CityID = 149, Name = "Elgin", StateID = 15, CountryID = 1 });
                items.Add(new City { CityID = 150, Name = "Joliet", StateID = 15, CountryID = 1 });
                items.Add(new City { CityID = 151, Name = "Chicago", StateID = 15, CountryID = 1 });
                items.Add(new City { CityID = 152, Name = "Aurora", StateID = 15, CountryID = 1 });

                items.Add(new City { CityID = 153, Name = "Boise", StateID = 14, CountryID = 1 });

                items.Add(new City { CityID = 154, Name = "Honolulu", StateID = 12, CountryID = 1 });

                items.Add(new City { CityID = 155, Name = "Savannah", StateID = 11, CountryID = 1 });
                items.Add(new City { CityID = 156, Name = "Columbus", StateID = 11, CountryID = 1 });
                items.Add(new City { CityID = 157, Name = "Athens", StateID = 11, CountryID = 1 });
                items.Add(new City { CityID = 158, Name = "Augusta", StateID = 11, CountryID = 1 });
                items.Add(new City { CityID = 160, Name = "Atlanta", StateID = 11, CountryID = 1 });

                items.Add(new City { CityID = 161, Name = "Miramar", StateID = 10, CountryID = 1 });
                items.Add(new City { CityID = 162, Name = "Miami Gardens", StateID = 10, CountryID = 1 });
                items.Add(new City { CityID = 163, Name = "Miami", StateID = 10, CountryID = 1 });
                items.Add(new City { CityID = 164, Name = "Port Saint Lucie", StateID = 10, CountryID = 1 });
                items.Add(new City { CityID = 165, Name = "Palm Bay", StateID = 10, CountryID = 1 });
                items.Add(new City { CityID = 166, Name = "Pembroke Pines", StateID = 10, CountryID = 1 });
                items.Add(new City { CityID = 167, Name = "Orlando", StateID = 10, CountryID = 1 });
                items.Add(new City { CityID = 168, Name = "Tallahassee", StateID = 10, CountryID = 1 });
                items.Add(new City { CityID = 169, Name = "Tampa", StateID = 10, CountryID = 1 });
                items.Add(new City { CityID = 170, Name = "Saint Petersburg", StateID = 10, CountryID = 1 });
                items.Add(new City { CityID = 171, Name = "Fort Lauderdale", StateID = 10, CountryID = 1 });
                items.Add(new City { CityID = 172, Name = "Gainesville", StateID = 10, CountryID = 1 });
                items.Add(new City { CityID = 173, Name = "Jacksonville", StateID = 10, CountryID = 1 });
                items.Add(new City { CityID = 174, Name = "Hollywood", StateID = 10, CountryID = 1 });
                items.Add(new City { CityID = 175, Name = "Hialeah", StateID = 10, CountryID = 1 });
                items.Add(new City { CityID = 176, Name = "Clearwater", StateID = 10, CountryID = 1 });
                items.Add(new City { CityID = 177, Name = "Coral Springs", StateID = 10, CountryID = 1 });
                items.Add(new City { CityID = 178, Name = "Cape Coral", StateID = 10, CountryID = 1 });


                items.Add(new City { CityID = 179, Name = "Washington", StateID = 8, CountryID = 1 });

                items.Add(new City { CityID = 180, Name = "New Haven", StateID = 7, CountryID = 1 });
                items.Add(new City { CityID = 181, Name = "Waterbury", StateID =7, CountryID = 1 });
                items.Add(new City { CityID = 182, Name = "Stamford", StateID = 7, CountryID = 1 });
                items.Add(new City { CityID = 184, Name = "Hartford", StateID = 7, CountryID = 1 });
                items.Add(new City { CityID = 185, Name = "Bridgeport", StateID = 7, CountryID = 1 });

                items.Add(new City { CityID = 186, Name = "Pueblo", StateID = 6, CountryID = 1 });
                items.Add(new City { CityID = 187, Name = "Thornton", StateID = 6, CountryID = 1 });
                items.Add(new City { CityID = 188, Name = "Westminster", StateID = 6, CountryID = 1 });
                items.Add(new City { CityID = 189, Name = "Fort Collins", StateID = 6, CountryID = 1 });
                items.Add(new City { CityID = 190, Name = "Lakewood", StateID = 6, CountryID = 1 });
                items.Add(new City { CityID = 191, Name = "Centennial", StateID = 6, CountryID = 1 });
                items.Add(new City { CityID = 192, Name = "Colorado Springs", StateID = 6, CountryID = 1 });
                items.Add(new City { CityID = 193, Name = "Denver ", StateID = 6, CountryID = 1 });
                items.Add(new City { CityID = 194, Name = "Arvada", StateID = 6, CountryID = 1 });
                items.Add(new City { CityID = 195, Name = "Aurora", StateID = 6, CountryID = 1 });

                items.Add(new City { CityID = 196, Name = "Los Angeles", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 197, Name = "Norwalk", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 198, Name = "Oakland", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 199, Name = "Murrieta", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 200, Name = "Moreno Valley", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 201, Name = "Modesto", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 202, Name = "Pomona", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 203, Name = "Richmond", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 204, Name = "Riverside", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 205, Name = "Rancho Cucamonga", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 206, Name = "Palmdale", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 207, Name = "Pasadena", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 208, Name = "Orange", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 209, Name = "Oxnard", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 210, Name = "Ontario", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 211, Name = "Oceanside", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 212, Name = "Sunnyvale", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 213, Name = "Temecula", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 214, Name = "Vallejo", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 215, Name = "Torrance", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 216, Name = "Thousand Oaks", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 217, Name = "West Covina", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 218, Name = "Visalia", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 219, Name = "Victorville", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 220, Name = "Santa Clara", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 221, Name = "Santa Clarita", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 222, Name = "Santa Rosa", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 223, Name = "Simi Valley", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 224, Name = "Stockton", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 225, Name = "San Buenaventura", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 226, Name = "San Bernardino", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 227, Name = "Santa Ana", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 228, Name = "San Jose", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 229, Name = "San Diego", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 230, Name = "San Francisco", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 231, Name = "Salinas", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 232, Name = "Sacramento", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 233, Name = "Roseville", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 234, Name = "El Monte", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 235, Name = "Escondido", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 236, Name = "Elk Grove", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 237, Name = "Fontana", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 238, Name = "Fairfield", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 239, Name = "Glendale", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 240, Name = "Fullerton", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 241, Name = "Garden Grove", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 242, Name = "Fresno", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 243, Name = "Fremont", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 244, Name = "Long Beach", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 245, Name = "Lancaster", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 246, Name = "Huntington Beach", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 247, Name = "Irvine", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 248, Name = "Inglewood", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 249, Name = "Hayward", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 250, Name = "Carlsbad", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 251, Name = "Chula Vista", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 252, Name = "Daly City", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 253, Name = "Downey", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 254, Name = "Corona", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 255, Name = "Costa Mesa", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 256, Name = "Concord", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 257, Name = "Bakersfield", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 258, Name = "Berkeley", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 259, Name = "Burbank", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 260, Name = "Antioch", StateID = 5, CountryID = 1 });
                items.Add(new City { CityID = 261, Name = "Anaheim", StateID = 5, CountryID = 1 });

                items.Add(new City { CityID = 262, Name = "Little Rock", StateID = 3, CountryID = 1 });

                items.Add(new City { CityID = 263, Name = "Mesa", StateID = 4, CountryID = 1 });
                items.Add(new City { CityID = 264, Name = "Phoenix", StateID = 4, CountryID = 1 });
                items.Add(new City { CityID = 265, Name = "Peoria", StateID = 4, CountryID = 1 });
                items.Add(new City { CityID = 266, Name = "Surprise", StateID = 4, CountryID = 1 });
                items.Add(new City { CityID = 267, Name = "Tempe", StateID = 4, CountryID = 1 });
                items.Add(new City { CityID = 268, Name = "Tucson", StateID = 4, CountryID = 1 });
                items.Add(new City { CityID = 269, Name = "Scottsdale", StateID = 4, CountryID = 1 });
                items.Add(new City { CityID = 270, Name = "Gilbert", StateID = 4, CountryID = 1 });
                items.Add(new City { CityID = 271, Name = "Glendale", StateID = 4, CountryID = 1 });
                items.Add(new City { CityID = 272, Name = "Chandler", StateID = 4, CountryID = 1 });

                items.Add(new City { CityID = 273, Name = "Anchorage", StateID = 1, CountryID = 1 });

                items.Add(new City { CityID = 274, Name = "Mobile", StateID = 2, CountryID = 1 });
                items.Add(new City { CityID = 275, Name = "Montgomery", StateID = 2, CountryID = 1 });
                items.Add(new City { CityID = 276, Name = "Huntsville", StateID = 2, CountryID = 1 });
                items.Add(new City { CityID = 277, Name = "Birmingham", StateID = 2, CountryID = 1 });
                                
                return items;
            }
        }
    }
}































