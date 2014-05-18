function Class_Static_Tower::onRemove(%this)
{

%this.Module_ID_Parent.Int_Static_Tower_Counter--;

%this.SimSet_Targets.delete();

}
