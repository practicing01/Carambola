function Class_Swamp_Creature::onRemove(%this)
{

%this.Module_ID_Parent.Int_Score++;

%this.Module_ID_Parent.Score_Update();

%this.Module_ID_Parent.Int_Offender_Count--;

%this.SimSet_Targets.delete();

}
