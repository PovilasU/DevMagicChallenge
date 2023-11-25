import { TestBed } from '@angular/core/testing';

import { DevmagicService } from './devmagic.service';

describe('DevmagicService', () => {
  let service: DevmagicService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DevmagicService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
