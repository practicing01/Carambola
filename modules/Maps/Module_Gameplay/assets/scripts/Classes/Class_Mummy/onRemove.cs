function Class_Mummy::onRemove(%this)
{

//Scene_Carambola.deleteJoint(%this.Joint_ID);

%this.Module_ID_Parent.Int_Score++;

%this.Module_ID_Parent.Score_Update();

%this.Module_ID_Parent.Int_Offender_Count--;

%this.SimSet_Targets.delete();

}
