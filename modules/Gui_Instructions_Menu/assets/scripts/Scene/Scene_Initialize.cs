function Module_Gui_Instructions_Menu::Scene_Initialize(%this)
{

%Text="Protect your Majesty.";
%Text=%Text NL "Do not let evil flood the kingdom.";
%Text=%Text NL "Use the landscape to your advantage.";
%Text=%Text NL "Heros of many talents will aid in battle.";
%Text=%Text NL "";
%Text=%Text NL "Credits for code and graphics to their respective authors.";
%Text=%Text NL "Thank you for playing. ~ practicing01";

%this.Gui_Text_ML=new GuiMLTextCtrl()
{
Position="0 0";
HorizSizing="relative";
VertSizing="relative";
Text=%Text; 
Extent=Carambola.Resolution;
isContainer="1";
Profile="Gui_Profile_Modalless_Text";
hovertime="1000";
MaxLength="512";
};

Gui_Instructions_Menu.addGuiControl(%this.Gui_Text_ML);

}
