// Copyright © 2023 Hugo Duchesne. All rights reserved.


#include "Models/Terrain.h"

// Sets default values for this component's properties
UTerrain::UTerrain()
{
	// Set this component to be initialized when the game starts, and to be ticked every frame.  You can turn these features
	// off to improve performance if you don't need them.
	PrimaryComponentTick.bCanEverTick = true;

	// ...
}


// Called when the game starts
void UTerrain::BeginPlay()
{
	Super::BeginPlay();

	// ...
	
}


// Called every frame
void UTerrain::TickComponent(float DeltaTime, ELevelTick TickType, FActorComponentTickFunction* ThisTickFunction)
{
	Super::TickComponent(DeltaTime, TickType, ThisTickFunction);

	// ...
}

