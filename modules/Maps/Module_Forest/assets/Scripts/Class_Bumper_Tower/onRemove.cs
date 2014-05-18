function Class_Bumper_Tower::onRemove(%this)
{

%this.Module_ID_Parent.Int_Bumper_Tower_Counter--;

%this.SimSet_Targets.delete();

}
