function Class_Slapper_Tower::onRemove(%this)
{

%this.Module_ID_Parent.Int_Slapper_Tower_Counter--;

%this.SimSet_Targets.delete();

}
