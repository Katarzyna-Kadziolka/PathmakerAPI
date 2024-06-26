﻿using FluentValidation;

namespace Pathmaker.Application.Requests.Products.Commands.CreateProduct;

public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand> {
    public CreateProductCommandValidator() {
        RuleFor(x => x.Name).MinimumLength(3).MaximumLength(10).NotEmpty();
    }
}