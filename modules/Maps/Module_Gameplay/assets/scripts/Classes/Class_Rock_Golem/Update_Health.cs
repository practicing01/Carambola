function Class_Rock_Golem::Update_Health(%this,%Int_Amount,%Char_Operation)
{

if (%Char_Operation==0)
{

%this.Int_Health=%Int_Amount;

}
else if (%Char_Operation==1)
{

%this.Int_Health+=%Int_Amount;

if (%this.Int_Health>100)
{

%this.Int_Health=100;

}

}
else if (%Char_Operation==-1)
{

%this.Int_Health-=%Int_Amount;

}

if (%this.Int_Health<=0)
{

%Sprite_Explosion=new Sprite()
{

Position=%this.Position;
Size=Module_Gameplay.Vector_2D_Explosion_Size;
Animation="Module_Gameplay:Animation_Explosion";
class="Class_Explosion";
SceneLayer=14;

Module_ID_Parent=Module_Gameplay;

};

Scene_Carambola.add(%Sprite_Explosion);

if (!%this.Bool_Petrified)
{

%this.Bool_Petrified=true;

%this.Int_Health=100;

%this.Int_Attack=0;

%this.setBodyType("static");

%this.setSceneGroup(4);

%this.setCollisionShapeIsSensor(%this.Collision_Shape_Index,true);

%this.Animation="Module_Gameplay:Animation_Rock_Golem_Stand_Down";

}
else
{

%this.safeDelete();

}

}

}
