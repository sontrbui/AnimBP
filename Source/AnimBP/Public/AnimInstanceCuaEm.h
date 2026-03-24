// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Animation/AnimInstance.h"
#include "AnimInstanceCuaEm.generated.h"

/**
 * 
 */
UCLASS()
class ANIMBP_API UAnimInstanceCuaEm : public UAnimInstance
{
	GENERATED_BODY()
	
public:
	virtual void NativeInitializeAnimation() override;

private:
	UPROPERTY(VisibleAnywhere, BlueprintReadOnly, Category = "AnimBP Cua Em", meta = (AllowPrivateAccess=true))
	TWeakObjectPtr<APawn> NhanVatDangXaiAnimBPCuaEm;
};
