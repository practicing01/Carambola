function Module_Gameplay::Scene_Initialize(%this)
{

exec("./Initialize/Initialize.cs");

%this.Variables_Initialize();

%this.Input_Initialize();

%this.World_Limits_Initialize();

%this.Floor_Initialize();

%this.Floor_Detail_Initialize();

%this.Module_ID_Map_Background.Generate_Gui_Towers();

%this.Score_Initialize();

%this.Offenders_Initialize();

%this.Defenders_Initialize();

%this.Royalty_Initialize();

}
