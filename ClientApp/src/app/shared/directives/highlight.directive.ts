import { Directive, ElementRef } from "@angular/core";
import { element } from "protractor";

@Directive({
  selector: "[appHightlight]",
})
export class HighlightDirective {
  constructor(el: ElementRef) {
    el.nativeElement.style.color = "fuchsia";
  }
}
