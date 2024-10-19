
using Secure_Munchester_United;

SecurityPassMaker check = new();

var stringToDisplay = check.GetDisplayName(new Physio());

check.Display(stringToDisplay);
