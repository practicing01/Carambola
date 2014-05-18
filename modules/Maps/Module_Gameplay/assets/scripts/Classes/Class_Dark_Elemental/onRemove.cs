function Class_Dark_Elemental::onRemove(%this)
{

%this.Module_ID_Parent.Int_Score++;

%this.Module_ID_Parent.Score_Update();

%this.Module_ID_Parent.Int_Offender_Count--;

Scene_Carambola.Controllers.remove(%this.PointForceController);

%this.PointForceController.delete();

%this.SimSet_Targets.delete();

}
