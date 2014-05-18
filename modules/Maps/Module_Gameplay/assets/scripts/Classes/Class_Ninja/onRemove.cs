function Class_Ninja::onRemove(%this)
{

%this.GuiButtonCtrl_Parent.Int_Defender_Count--;

%this.SimSet_Targets.delete();

}
