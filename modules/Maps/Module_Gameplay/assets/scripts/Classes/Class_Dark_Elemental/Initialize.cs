function Class_Dark_Elemental::Initialize(%this)
{

%this.PointForceController=new PointForceController();

%Radius=%this.Size.X;

if (%this.Size.X<%this.Size.Y)
{

%Radius=%this.Size.Y;

}

%this.PointForceController.Radius=%Radius*2;

%this.PointForceController.Force=200;

%this.PointForceController.NonLinear=true;

%this.PointForceController.LinearDrag=0.1;

%this.PointForceController.AngularDrag=0;

%this.PointForceController.setControlGroups(1);//Defenders

Scene_Carambola.Controllers.add(%this.PointForceController);

%this.PointForceController.setTrackedObject(%this);

}
