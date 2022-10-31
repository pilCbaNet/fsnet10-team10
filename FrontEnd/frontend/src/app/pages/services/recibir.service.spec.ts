import { TestBed } from '@angular/core/testing';

import { RecibirService } from './recibir.service';

describe('RecibirService', () => {
  let service: RecibirService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(RecibirService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
