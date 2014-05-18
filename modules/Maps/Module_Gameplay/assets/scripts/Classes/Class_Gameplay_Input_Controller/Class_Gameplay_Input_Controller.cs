function Class_Gameplay_Input_Controller::onTouchDown(%this,%touchID,%Vector_2D_World_Position)
{

if (%this.Module_ID_Parent.Bool_Casting_Defender)
{

//%this.Module_ID_Parent.Bool_Casting_Defender=false;

%this.Module_ID_Parent.Cast_Defenders(%Vector_2D_World_Position);

}

}

function Class_Gameplay_Input_Controller::onTouchUp(%this,%touchID,%Vector_2D_World_Position)
{

%this.Module_ID_Parent.Int_Casting_Interval_Counter=0;

}

function Class_Gameplay_Input_Controller::onTouchDragged(%this,%touchID,%Vector_2D_World_Position)
{

%this.Module_ID_Parent.Int_Casting_Interval_Counter++;

if (%this.Module_ID_Parent.Int_Casting_Interval_Counter>=%this.Module_ID_Parent.Int_Casting_Interval)
{

%this.Module_ID_Parent.Int_Casting_Interval_Counter=0;

if (%this.Module_ID_Parent.Bool_Casting_Defender)
{

//%this.Module_ID_Parent.Bool_Casting_Defender=false;

%this.Module_ID_Parent.Cast_Defenders(%Vector_2D_World_Position);

}

}

}
