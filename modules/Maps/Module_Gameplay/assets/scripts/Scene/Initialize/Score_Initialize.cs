function Module_Gameplay::Score_Update(%this)
{

if (!isObject(%this.Gui_Text_Score)){return;}

%this.Gui_Text_Score.setText("Gibs:" SPC %this.Int_Score);

}

function Module_Gameplay::Score_Initialize(%this)
{

%this.Gui_Text_Score=new GuiMLTextCtrl()
{

Position=Vector_2D_Vector_To_Resolution_By_Resolution_Scale("275 0","800 480",Carambola.Resolution);
HorizSizing="relative";
VertSizing="relative";
Text="Gibs: 0"; 
Extent="250 100";
Profile="Gui_Profile_Modalless_Text";
hovertime="1000";
MaxLength="512";

};

Gui_Carambola_Overlay.addGuiControl(%this.Gui_Text_Score);

}
