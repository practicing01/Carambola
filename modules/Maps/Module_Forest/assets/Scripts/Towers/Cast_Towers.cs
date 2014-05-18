function Module_Forest::Cast_Towers(%this,%Vector_2D_World_Position)
{

if (!Module_Gameplay.Bool_Can_Cast_Towers){return;}

if (%this.String_Casting_Tower_Type$="Static")
{

if (%this.Int_Static_Tower_Counter>=%this.Int_Static_Tower_Max){return;}

%ScriptObject_String_Tile=%this.SimSet_String_Static_Tower_Tiles.getObject(getRandom(0,%this.SimSet_String_Static_Tower_Tiles.getCount()-1));

%Sprite_Tower=new Sprite()
{

Position=%Vector_2D_World_Position;
Size=Vector_2D_Ass_Size_To_Camera_Scale(%ScriptObject_String_Tile.Ass_Image);
Image=%ScriptObject_String_Tile.String_Name;
class="Class_Static_Tower";
CollisionCallback="true";
SceneLayer=16;

BodyType="static";

FixedAngle=true;

SceneGroup=0;//Towers.

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

Int_Health=100;

Int_Attack=10;

SimSet_Targets=0;

Bool_Targetable=true;

Bool_Blind=false;

Bool_Poisoned=false;

};

%Sprite_Tower.SimSet_Targets=new SimSet();

%Sprite_Tower.setCollisionGroups(1,2,3,4);//Defenders, Offenders, Collidable Defender Sensor, Collidable Offender Sensor

%Sprite_Tower.Collision_Shape_Index=%Sprite_Tower.createPolygonBoxCollisionShape(%Sprite_Tower.Size);

Scene_Carambola.add(%Sprite_Tower);

%this.Int_Static_Tower_Counter++;

}
else if (%this.String_Casting_Tower_Type$="Slapper")
{

if (%this.Int_Slapper_Tower_Counter>=%this.Int_Slapper_Tower_Max){return;}

%ScriptObject_String_Tile=%this.SimSet_String_Slapper_Tower_Tiles.getObject(getRandom(0,%this.SimSet_String_Slapper_Tower_Tiles.getCount()-1));

%Sprite_Tower=new Sprite()
{

Position=%Vector_2D_World_Position;
Size=Vector_2D_Ass_Size_To_Camera_Scale(%ScriptObject_String_Tile.Ass_Image);
Image=%ScriptObject_String_Tile.String_Name;
class="Class_Slapper_Tower";
CollisionCallback="true";
SceneLayer=16;

BodyType="kinematic";

AngularVelocity=2000;

SceneGroup=0;//Towers.

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

Int_Health=100;

Int_Attack=10;

SimSet_Targets=0;

Bool_Targetable=true;

Bool_Blind=false;

Bool_Poisoned=false;

};

%Sprite_Tower.SimSet_Targets=new SimSet();

%Sprite_Tower.setCollisionGroups(1,2,3,4);//Defenders, Offenders, Collidable Defender Sensor, Collidable Offender Sensor

%Sprite_Tower.Collision_Shape_Index=%Sprite_Tower.createPolygonBoxCollisionShape(%Sprite_Tower.Size);

Scene_Carambola.add(%Sprite_Tower);

%this.Int_Slapper_Tower_Counter++;

}
else if (%this.String_Casting_Tower_Type$="Bumper")
{

if (%this.Int_Bumper_Tower_Counter>=%this.Int_Bumper_Tower_Max){return;}

%ScriptObject_String_Tile=%this.SimSet_String_Bumper_Tower_Tiles.getObject(getRandom(0,%this.SimSet_String_Bumper_Tower_Tiles.getCount()-1));

%Sprite_Tower=new Sprite()
{

Position=%Vector_2D_World_Position;
Size=Vector_2D_Ass_Size_To_Camera_Scale(%ScriptObject_String_Tile.Ass_Image);
Image=%ScriptObject_String_Tile.String_Name;
class="Class_Bumper_Tower";
CollisionCallback="true";
SceneLayer=16;

BodyType="static";

FixedAngle=true;

SceneGroup=0;//Towers.

Module_ID_Parent=%this;

Collision_Shape_Index=-1;

Int_Health=100;

Int_Attack=10;

SimSet_Targets=0;

Bool_Targetable=true;

Bool_Blind=false;

Bool_Poisoned=false;

};

%Sprite_Tower.SimSet_Targets=new SimSet();

%Sprite_Tower.setCollisionGroups(1,2,3,4);//Defenders, Offenders, Collidable Defender Sensor, Collidable Offender Sensor

%Sprite_Tower.Collision_Shape_Index=%Sprite_Tower.createPolygonBoxCollisionShape(%Sprite_Tower.Size);

Scene_Carambola.add(%Sprite_Tower);

%this.Int_Bumper_Tower_Counter++;

}

}
