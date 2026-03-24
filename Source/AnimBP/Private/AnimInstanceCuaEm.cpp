// Fill out your copyright notice in the Description page of Project Settings.


#include "AnimInstanceCuaEm.h"

void UAnimInstanceCuaEm::NativeInitializeAnimation()
{
	Super::NativeInitializeAnimation();
	
	NhanVatDangXaiAnimBPCuaEm = TryGetPawnOwner();
	if (NhanVatDangXaiAnimBPCuaEm.IsValid())
	{
		UE_LOG(LogTemp, Warning, TEXT("AnimInstanceCuaEm::NativeInitializeAnimation: NhanVatDangXaiAnimBPCuaEm is valid"));
	}
	else
	{
		UE_LOG(LogTemp, Warning, TEXT("AnimInstanceCuaEm::NativeInitializeAnimation: NhanVatDangXaiAnimBPCuaEm is NOT valid"));
	}
}
